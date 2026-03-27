<template>
    <div class="existencias-root">
  
      <!-- Header -->
      <div class="page-header">
        <div class="header-left">
          <div class="header-icon">
            <svg viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="1.5">
              <path d="M20 7H4a2 2 0 0 0-2 2v6a2 2 0 0 0 2 2h16a2 2 0 0 0 2-2V9a2 2 0 0 0-2-2z"/>
              <path d="M16 21V5a2 2 0 0 0-2-2h-4a2 2 0 0 0-2 2v16"/>
            </svg>
          </div>
          <div>
            <h1 class="page-title">Existencias de Inventario</h1>
            <p class="page-sub">Stock actual por producto · {{ empresaNombre }}</p>
          </div>
        </div>
        <div class="header-actions">
          <button class="btn-export excel" @click="exportarExcel" :disabled="!hayDatos">
            <svg viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2"><path d="M14 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V8z"/><polyline points="14 2 14 8 20 8"/></svg>
            Excel
          </button>
          <button class="btn-export pdf" @click="exportarPDF" :disabled="!hayDatos">
            <svg viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2"><path d="M14 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V8z"/><polyline points="14 2 14 8 20 8"/></svg>
            PDF
          </button>
        </div>
      </div>
  
      <!-- Filtros -->
      <div class="filtros-card">
  <div class="filtros-grid">
    <div class="filtro-group">
      <label>Buscar producto</label>
      <div class="search-wrap">
        <input
          v-model="busqueda"
          type="text"
          placeholder="Código o descripción..."
          @input="ejecutarBusqueda" 
        />
        <svg class="search-icon" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2">
          <circle cx="11" cy="11" r="8"/><line x1="21" y1="21" x2="16.65" y2="16.65"/>
        </svg>
      </div>
    </div>

    <div class="filtro-group">
      <label>Categoría</label>
      <select v-model="filtroCategoria" @change="cargarDatos(1)">
        <option value="">Todas</option>
        <option v-for="c in categorias" :key="c" :value="c">{{ c }}</option>
      </select>
    </div>

    <div class="filtro-group">
      <label>Estado</label>
      <select v-model="filtroEstado" @change="cargarDatos(1)">
        <option value="">Todos</option>
        <option value="ok">En stock</option>
        <option value="bajo">Bajo mínimo</option>
        <option value="sin">Sin stock</option>
      </select>
    </div>

    <div class="filtro-group filtro-action">
      <button class="btn-buscar" @click="cargarDatos()" :disabled="cargando">
        <svg v-if="!cargando" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2.5">
          <polyline points="1 4 1 10 7 10"/><path d="M3.51 15a9 9 0 1 0 .49-3.86"/>
        </svg>
        <svg v-else class="spin" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2.5">
          <path d="M12 2a10 10 0 0 1 10 10"/>
        </svg>
        {{ cargando ? 'Cargando...' : 'Actualizar' }}
      </button>
    </div>
  </div>
</div>
<!-- KPIs Globales -->
<div v-if="hayDatos" class="kpis-row">
  <div class="kpi-card total">
    <div class="kpi-data">
      <span class="kpi-label">Total Productos</span>
      <span class="kpi-value">{{ kpisGlobales.total }}</span>
    </div>
  </div>
  <div class="kpi-card ok">
    <div class="kpi-data">
      <span class="kpi-label">En Stock</span>
      <span class="kpi-value">{{ kpisGlobales.enStock }}</span>
    </div>
  </div>
  <div class="kpi-card bajo">
    <div class="kpi-data">
      <span class="kpi-label">Bajo Mínimo</span>
      <span class="kpi-value">{{ kpisGlobales.bajoMinimo }}</span>
    </div>
  </div>
  <div class="kpi-card sin">
    <div class="kpi-data">
      <span class="kpi-label">Sin Stock</span>
      <span class="kpi-value">{{ kpisGlobales.sinStock }}</span>
    </div>
  </div>
</div>
  
      <!-- Tabla -->
      <div v-if="hayDatos" class="tabla-card">
        <div class="tabla-header">
          <h3>Existencias Actuales</h3>
          <div class="tabla-header-right">
            <span class="tabla-count">{{ productosFiltrados.length }} productos</span>
            <!-- Ordenar -->
            <select v-model="ordenarPor" @change="ordenar" class="select-orden">
              <option value="descripcion">A-Z</option>
              <option value="existencia_asc">Menor existencia</option>
              <option value="existencia_desc">Mayor existencia</option>
              <option value="categoria">Categoría</option>
            </select>
          </div>
        </div>
        <div class="tabla-scroll">
          <table>
            <thead>
              <tr>
                <th>Código</th>
                <th>Descripción</th>
                <th>Categoría</th>
                <th>Unidad</th>
                <th class="num">Stock Mín.</th>
                <th class="num">Existencia</th>
                <th class="num">Costo Prom.</th>
                <th class="num">Precio</th>
                <th>Estado</th>
              </tr>
            </thead>
            <tbody>
              <tr
                v-for="(p, i) in productosFiltrados"
                :key="i"
                :class="getRowClass(p)"
              >
                <td class="codigo">{{ p.codigo }}</td>
                <td class="desc">{{ p.descripcion }}</td>
                <td class="cat">{{ p.categoria || '—' }}</td>
                <td class="uni">{{ p.unidad || '—' }}</td>
                <td class="num">{{ formatNum(p.stockMinimo) }}</td>
                <td class="num existencia-val" :class="getExistenciaClass(p)">
                  {{ formatNum(p.existencia) }}
                </td>
                <td class="num">{{ p.costoPromedio > 0 ? formatMoney(p.costoPromedio) : formatMoney(p.costo) }}</td>
                <td class="num">{{ formatMoney(p.precioUno) }}</td>
                <td>
                  <span class="badge" :class="getBadgeClass(p)">
                    {{ getBadgeText(p) }}
                  </span>
                </td>
              </tr>
            </tbody>
          </table>
        </div>
      </div>
      
      <div v-if="totalPaginas > 1" class="pagination-bar">
  <div class="pagination-info">
    Página <b>{{ paginaActual }}</b> de <b>{{ totalPaginas }}</b>
    <span class="total-count">({{ totalRegistros }} registros encontrados)</span>
  </div>
  <div class="pagination-buttons">
    <button 
      class="btn-nav" 
      :disabled="paginaActual === 1 || cargando" 
      @click="cargarDatos(paginaActual - 1)"
    >
      &larr; Anterior
    </button>
    
    <button 
      class="btn-nav" 
      :disabled="paginaActual === totalPaginas || cargando" 
      @click="cargarDatos(paginaActual + 1)"
    >
      Siguiente &rarr;
    </button>
  </div>
  </div>
      <!-- Loading -->
      <div v-if="cargando" class="loading-state">
        <svg class="spin" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2">
          <path d="M12 2a10 10 0 0 1 10 10"/>
        </svg>
        <p>Cargando existencias...</p>
      </div>
  
      <!-- Empty -->
      <div v-else-if="!cargando && !hayDatos" class="empty-state">
        <svg viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="1.5">
          <path d="M20 7H4a2 2 0 0 0-2 2v6a2 2 0 0 0 2 2h16a2 2 0 0 0 2-2V9a2 2 0 0 0-2-2z"/>
        </svg>
        <p>No se encontraron productos.</p>
      </div>
  
    </div>
  </template>

  <script setup lang="ts">
  import { ref, computed, onMounted } from 'vue'
  import axios from 'axios'
  import { useAuthStore } from '@/stores/auth'
  import api from '@/api/config'
  const filtroCategoria = ref('')
  const filtroEstado = ref('')
  const auth = useAuthStore()
 
  
  // 1. Declaramos la variable reactiva
const categorias = ref<string[]>([])

// 2. Función para obtenerlas del API
const cargarCategorias = async () => {
  try {

    const res = await api.get('/api/kardex/categorias', {
      headers: { Authorization: `Bearer ${auth.token}` }
    })
    categorias.value = res.data
  } catch (e) {
    console.error('Error cargando categorías:', e)
  }
}

// 3. Ejecutamos al montar el componente
onMounted(() => {
  cargarDatos()       // Trae los productos paginados
  cargarCategorias()  // Trae la lista para el <select>
})


  let debounceTimer: ReturnType<typeof setTimeout> 
  
  // --- Estado de la Interfaz ---
  const empresaNombre = ref(auth.empresa || 'CloudPocket')
  const cargando = ref(false)
  const busqueda = ref('')
  const ordenarPor = ref('descripcion')
  
  // --- Datos del API ---
  const productosFiltrados = ref<any[]>([])
  const kpisGlobales = ref({
    total: 0,
    enStock: 0,
    bajoMinimo: 0,
    sinStock: 0
  })
  
  // --- Paginación ---
  const paginaActual = ref(1)
  const totalRegistros = ref(0)
  const registrosPorPagina = ref(50)
  
  const hayDatos = computed(() => productosFiltrados.value.length > 0)
  const totalPaginas = computed(() => Math.ceil(totalRegistros.value / registrosPorPagina.value))
  
  // --- Carga de Datos (Ahora con Paginación) ---
  const cargarDatos = async (pagina = 1) => {
  cargando.value = true
  paginaActual.value = pagina
  try {
    const res = await api.get('/api/kardex/existencias', {
      params: { 
        q: busqueda.value || undefined,
        categoria: filtroCategoria.value || undefined,
        estado: filtroEstado.value || undefined,
        pagina: pagina, 
        size: registrosPorPagina.value 
      },
      headers: { Authorization: `Bearer ${auth.token}` }
    })
    productosFiltrados.value = res.data.items
    kpisGlobales.value = res.data.totales
    totalRegistros.value = res.data.totales.total
    ordenar()
  } catch (e) {
    console.error('Error cargando existencias', e)
  } finally {
    cargando.value = false
  }
}
  
  // Búsqueda con Debounce (Vuelve a la página 1)
  const ejecutarBusqueda = () => {
    clearTimeout(debounceTimer)
    debounceTimer = setTimeout(() => {
      cargarDatos(1)
    }, 400)
  }
  
  const ordenar = () => {
    const data = [...productosFiltrados.value]
    if (ordenarPor.value === 'descripcion') {
      data.sort((a, b) => (a.descripcion || '').localeCompare(b.descripcion || ''))
    } else if (ordenarPor.value === 'existencia_asc') {
      data.sort((a, b) => a.existencia - b.existencia)
    } else if (ordenarPor.value === 'existencia_desc') {
      data.sort((a, b) => b.existencia - a.existencia)
    }
    productosFiltrados.value = data
  }
  
  // --- Helpers de Estilo ---
  const getRowClass = (p: any) => {
    if (p.existencia <= 0) return 'row-sin'
    if (p.stockMinimo > 0 && p.existencia <= p.stockMinimo) return 'row-bajo'
    return ''
  }
  
  const getExistenciaClass = (p: any) => {
    if (p.existencia <= 0) return 'existencia-sin'
    if (p.stockMinimo > 0 && p.existencia <= p.stockMinimo) return 'existencia-bajo'
    return 'existencia-ok'
  }
  
  const getBadgeClass = (p: any) => {
    if (p.existencia <= 0) return 'badge-sin'
    if (p.stockMinimo > 0 && p.existencia <= p.stockMinimo) return 'badge-bajo'
    return 'badge-ok'
  }
  
  const getBadgeText = (p: any) => {
    if (p.existencia <= 0) return 'Sin stock'
    if (p.stockMinimo > 0 && p.existencia <= p.stockMinimo) return 'Bajo mínimo'
    return 'En stock'
  }
  
  // --- Exportaciones ---
  const exportarExcel = async () => {
  try {
    const res = await api.get('/api/kardex/existencias/excel', {
      params: { q: busqueda.value || undefined },
      headers: { Authorization: `Bearer ${auth.token}` },
      responseType: 'blob' // Importante para archivos
    })
    const url = URL.createObjectURL(new Blob([res.data]))
    const a = document.createElement('a')
    a.href = url
    a.download = `Existencias_${new Date().toISOString().split('T')[0]}.xlsx`
    a.click()
  } catch (e) { console.error('Error Excel', e) }
}

const exportarPDF = async () => {
  try {
    const res = await api.get('/api/kardex/existencias/pdf', {
      params: { q: busqueda.value || undefined },
      headers: { Authorization: `Bearer ${auth.token}` },
      responseType: 'blob'
    })
    const url = URL.createObjectURL(new Blob([res.data], { type: 'application/pdf' }))
    window.open(url, '_blank')
  } catch (e) { console.error('Error PDF', e) }
}
  
  const formatNum = (n: number) => (n || 0).toLocaleString('es-SV', { minimumFractionDigits: 2, maximumFractionDigits: 2 })
  const formatMoney = (n: number) => `$${(n || 0).toLocaleString('es-SV', { minimumFractionDigits: 2 })}`
  
  onMounted(() => cargarDatos())
  </script>
  <style scoped>
  .existencias-root {
    padding: 24px;
    min-height: 100vh;
    background: #f5f5f7;
    font-family: 'SF Pro Display', -apple-system, sans-serif;
  }
  
  .page-header {
    display: flex;
    align-items: center;
    justify-content: space-between;
    margin-bottom: 20px;
  }
  .header-left { display: flex; align-items: center; gap: 14px; }
  .header-icon {
    width: 44px; height: 44px;
    background: #1d1d1f;
    border-radius: 12px;
    display: flex; align-items: center; justify-content: center;
  }
  .header-icon svg { width: 20px; height: 20px; stroke: white; }
  .page-title { font-size: 22px; font-weight: 700; color: #1d1d1f; margin: 0; }
  .page-sub { font-size: 12px; color: #86868b; margin: 2px 0 0; }
  
  .header-actions { display: flex; gap: 8px; }
  .btn-export {
    display: flex; align-items: center; gap: 6px;
    padding: 8px 16px; border-radius: 10px;
    font-size: 13px; font-weight: 500; border: none; cursor: pointer;
    transition: all 0.15s;
  }
  .btn-export svg { width: 14px; height: 14px; }
  .btn-export.excel { background: #e8f5e9; color: #2e7d32; }
  .btn-export.excel:hover { background: #2e7d32; color: white; }
  .btn-export.pdf { background: #fce4ec; color: #c62828; }
  .btn-export.pdf:hover { background: #c62828; color: white; }
  .btn-export:disabled { opacity: 0.4; cursor: not-allowed; }
  
  .filtros-card {
    background: white;
    border-radius: 16px;
    padding: 20px;
    margin-bottom: 16px;
    box-shadow: 0 1px 3px rgba(0,0,0,0.06);
    border: 1px solid rgba(0,0,0,0.06);
  }
  .filtros-grid {
    display: grid;
    grid-template-columns: 1fr 180px 180px auto;
    gap: 16px;
    align-items: end;
  }
  .filtro-group { display: flex; flex-direction: column; gap: 6px; }
  .filtro-group label { font-size: 11px; font-weight: 600; color: #86868b; text-transform: uppercase; letter-spacing: 0.5px; }
  .filtro-group input,
  .filtro-group select {
    padding: 9px 12px;
    border-radius: 10px;
    border: 1px solid rgba(0,0,0,0.1);
    background: rgba(0,0,0,0.03);
    font-size: 13px; color: #1d1d1f;
    outline: none; transition: all 0.15s;
  }
  .filtro-group input:focus,
  .filtro-group select:focus {
    border-color: #0071e3;
    box-shadow: 0 0 0 3px rgba(0,113,227,0.12);
  }
  .search-wrap { position: relative; }
  .search-wrap input { width: 100%; padding-right: 36px; box-sizing: border-box; }
  .search-icon { position: absolute; right: 10px; top: 50%; transform: translateY(-50%); width: 16px; height: 16px; stroke: #86868b; pointer-events: none; }
  
  .btn-buscar {
    display: flex; align-items: center; gap: 8px;
    padding: 10px 20px; border-radius: 10px;
    background: #1d1d1f; color: white;
    font-size: 13px; font-weight: 600; border: none; cursor: pointer;
    transition: all 0.15s; white-space: nowrap;
  }
  .btn-buscar:hover { background: #0071e3; }
  .btn-buscar:disabled { opacity: 0.5; cursor: not-allowed; }
  .btn-buscar svg { width: 15px; height: 15px; }
  .spin { animation: spin 0.8s linear infinite; }
  @keyframes spin { to { transform: rotate(360deg); } }
  
  .kpis-row {
    display: grid;
    grid-template-columns: repeat(4, 1fr);
    gap: 12px;
    margin-bottom: 16px;
  }
  .kpi-card {
    background: white;
    border-radius: 14px;
    padding: 16px 18px;
    display: flex; align-items: center; gap: 14px;
    box-shadow: 0 1px 3px rgba(0,0,0,0.06);
    border: 1px solid rgba(0,0,0,0.06);
  }
  .kpi-icon { width: 40px; height: 40px; border-radius: 10px; display: flex; align-items: center; justify-content: center; flex-shrink: 0; }
  .kpi-icon svg { width: 18px; height: 18px; }
  .kpi-card.total .kpi-icon { background: #e3f2fd; }
  .kpi-card.total .kpi-icon svg { stroke: #1565c0; }
  .kpi-card.ok .kpi-icon { background: #e8f5e9; }
  .kpi-card.ok .kpi-icon svg { stroke: #2e7d32; }
  .kpi-card.bajo .kpi-icon { background: #fff8e1; }
  .kpi-card.bajo .kpi-icon svg { stroke: #f57f17; }
  .kpi-card.sin .kpi-icon { background: #fce4ec; }
  .kpi-card.sin .kpi-icon svg { stroke: #c62828; }
  .kpi-data { display: flex; flex-direction: column; }
  .kpi-label { font-size: 11px; color: #86868b; font-weight: 500; }
  .kpi-value { font-size: 20px; font-weight: 700; color: #1d1d1f; }
  
  .tabla-card {
    background: white;
    border-radius: 16px;
    overflow: hidden;
    box-shadow: 0 1px 3px rgba(0,0,0,0.06);
    border: 1px solid rgba(0,0,0,0.06);
  }
  .tabla-header {
    display: flex; align-items: center; justify-content: space-between;
    padding: 16px 20px; border-bottom: 1px solid rgba(0,0,0,0.06);
  }
  .tabla-header h3 { font-size: 14px; font-weight: 600; color: #1d1d1f; margin: 0; }
  .tabla-header-right { display: flex; align-items: center; gap: 10px; }
  .tabla-count { font-size: 12px; color: #86868b; background: #f5f5f7; padding: 3px 10px; border-radius: 20px; }
  .select-orden {
    padding: 5px 10px; border-radius: 8px;
    border: 1px solid rgba(0,0,0,0.1);
    font-size: 12px; color: #1d1d1f;
    background: #f5f5f7; outline: none; cursor: pointer;
  }
  
  .tabla-scroll { overflow-x: auto; }
  table { width: 100%; border-collapse: collapse; font-size: 13px; }
  thead tr { background: #f5f5f7; }
  th {
    padding: 10px 14px; text-align: left;
    font-size: 11px; font-weight: 600; color: #86868b;
    text-transform: uppercase; letter-spacing: 0.5px;
    border-bottom: 1px solid rgba(0,0,0,0.06);
  }
  th.num { text-align: right; }
  td { padding: 10px 14px; border-bottom: 1px solid rgba(0,0,0,0.04); color: #1d1d1f; }
  td.num { text-align: right; font-variant-numeric: tabular-nums; }
  td.codigo { font-weight: 700; font-size: 12px; color: #0071e3; }
  td.desc { max-width: 250px; }
  td.cat { font-size: 12px; color: #86868b; }
  td.uni { font-size: 12px; color: #86868b; }
  tr:hover td { background: rgba(0,0,0,0.015); }
  
  .row-bajo td { background: rgba(245,127,23,0.04); }
  .row-sin td { background: rgba(198,40,40,0.04); }
  
  .existencia-ok   { color: #2e7d32; font-weight: 700; }
  .existencia-bajo { color: #f57f17; font-weight: 700; }
  .existencia-sin  { color: #c62828; font-weight: 700; }
  
  .badge {
    display: inline-block;
    padding: 3px 10px; border-radius: 20px;
    font-size: 11px; font-weight: 600;
  }
  .badge-ok   { background: #e8f5e9; color: #2e7d32; }
  .badge-bajo { background: #fff8e1; color: #f57f17; }
  .badge-sin  { background: #fce4ec; color: #c62828; }
  
  .loading-state, .empty-state {
    display: flex; flex-direction: column; align-items: center; justify-content: center;
    padding: 60px 20px; gap: 12px;
    background: white; border-radius: 16px;
    border: 1px solid rgba(0,0,0,0.06);
  }
  .loading-state svg, .empty-state svg { width: 48px; height: 48px; stroke: #c7c7cc; }
  .loading-state p, .empty-state p { font-size: 14px; color: #86868b; margin: 0; }
  
  @media (max-width: 768px) {
    .filtros-grid { grid-template-columns: 1fr; }
    .kpis-row { grid-template-columns: repeat(2, 1fr); }
    .header-actions { display: none; }
  }

  .pagination-bar {
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding: 14px 20px;
  background: white;
  border-radius: 14px;
  margin-top: 12px;
  box-shadow: 0 1px 3px rgba(0,0,0,0.06);
  border: 1px solid rgba(0,0,0,0.06);
}

.pagination-info {
  font-size: 13px;
  color: #86868b;
}

.pagination-info b {
  color: #1d1d1f;
}

.total-count {
  margin-left: 6px;
  font-size: 12px;
  color: #c7c7cc;
}

.pagination-buttons {
  display: flex;
  gap: 8px;
}

.btn-nav {
  padding: 8px 16px;
  border-radius: 10px;
  border: 1px solid rgba(0,0,0,0.1);
  background: white;
  font-size: 13px;
  font-weight: 500;
  color: #1d1d1f;
  cursor: pointer;
  transition: all 0.15s;
}

.btn-nav:hover:not(:disabled) {
  background: #1d1d1f;
  color: white;
  border-color: #1d1d1f;
}

.btn-nav:disabled {
  opacity: 0.4;
  cursor: not-allowed;
}
  </style>