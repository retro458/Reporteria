<template>
  <div class="kardex-root">

    <!-- Header -->
    <div class="page-header">
      <div class="header-left">
        <div class="header-icon">
          <svg viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="1.5">
            <path d="M3 3h18v4H3zM3 10h18v4H3zM3 17h18v4H3z"/>
          </svg>
        </div>
        <div>
          <h1 class="page-title">Kardex General</h1>
          <p class="page-sub">Todos los movimientos · {{ empresaNombre }}</p>
        </div>
      </div>
      <div class="header-actions">
        <button class="btn-export excel" @click="exportarExcel" :disabled="!hayDatos">
          <svg viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2"><path d="M14 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V8z"/><polyline points="14 2 14 8 20 8"/><line x1="8" y1="13" x2="16" y2="13"/><line x1="8" y1="17" x2="16" y2="17"/></svg>
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
          <label>Desde</label>
          <input type="date" v-model="filtros.desde" />
        </div>

        <div class="filtro-group">
          <label>Hasta</label>
          <input type="date" v-model="filtros.hasta" />
        </div>

        <div class="filtro-group filtro-action">
          <button class="btn-buscar" @click="buscarKardex" :disabled="cargando">
            <svg v-if="!cargando" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2.5">
              <circle cx="11" cy="11" r="8"/><line x1="21" y1="21" x2="16.65" y2="16.65"/>
            </svg>
            <svg v-else class="spin" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2.5">
              <path d="M12 2a10 10 0 0 1 10 10"/>
            </svg>
            {{ cargando ? 'Buscando...' : 'Buscar' }}
          </button>
        </div>

      </div>
    </div>

    <!-- KPIs -->
    <div v-if="hayDatos" class="kpis-row">
      <div class="kpi-card entradas">
        <div class="kpi-icon">
          <svg viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2"><polyline points="17 11 12 6 7 11"/><line x1="12" y1="18" x2="12" y2="6"/></svg>
        </div>
        <div class="kpi-data">
          <span class="kpi-label">Total Entradas</span>
          <span class="kpi-value">{{ formatNum(resumen.totalEntradas) }}</span>
        </div>
      </div>
      <div class="kpi-card salidas">
        <div class="kpi-icon">
          <svg viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2"><polyline points="7 13 12 18 17 13"/><line x1="12" y1="6" x2="12" y2="18"/></svg>
        </div>
        <div class="kpi-data">
          <span class="kpi-label">Total Salidas</span>
          <span class="kpi-value">{{ formatNum(resumen.totalSalidas) }}</span>
        </div>
      </div>
      <div class="kpi-card productos">
        <div class="kpi-icon">
          <svg viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2"><rect x="2" y="3" width="20" height="14" rx="2"/><line x1="8" y1="21" x2="16" y2="21"/><line x1="12" y1="17" x2="12" y2="21"/></svg>
        </div>
        <div class="kpi-data">
          <span class="kpi-label">Productos</span>
          <span class="kpi-value">{{ resumen.totalProductos }}</span>
        </div>
      </div>
      <div class="kpi-card movimientos">
        <div class="kpi-icon">
          <svg viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2"><line x1="8" y1="6" x2="21" y2="6"/><line x1="8" y1="12" x2="21" y2="12"/><line x1="8" y1="18" x2="21" y2="18"/><line x1="3" y1="6" x2="3.01" y2="6"/><line x1="3" y1="12" x2="3.01" y2="12"/><line x1="3" y1="18" x2="3.01" y2="18"/></svg>
        </div>
        <div class="kpi-data">
          <span class="kpi-label">Movimientos</span>
          <span class="kpi-value">{{ resumen.totalMovimientos }}</span>
        </div>
      </div>
    </div>

    <!-- Tabla -->
    <div v-if="hayDatos" class="tabla-card">
      <div class="tabla-header">
        <h3>Detalle de Movimientos</h3>
        <div class="tabla-header-right">
          <span class="tabla-count">{{ kardexData.length }} registros</span>
          <select v-model="ordenarPor" @change="ordenar" class="select-orden">
            <option value="fecha_desc">Más reciente</option>
            <option value="fecha_asc">Más antiguo</option>
            <option value="codigo">Por código</option>
          </select>
        </div>
      </div>
      <div class="tabla-scroll">
        <table>
          <thead>
            <tr>
              <th>Fecha</th>
              <th>Código</th>
              <th>Descripción</th>
              <th>Documento</th>
              <th>Correlativo</th>
              <th>Cliente / Proveedor</th>
              <th class="num">Entrada</th>
              <th class="num">Salida</th>
              <th class="num">Costo Unit.</th>
            </tr>
          </thead>
          <tbody>
            <tr
              v-for="(row, i) in kardexData"
              :key="i"
              :class="{ 'row-entrada': row.entrada > 0, 'row-salida': row.salida > 0 }"
            >
              <td class="fecha">{{ formatFecha(row.fecha) }}</td>
              <td class="codigo">{{ row.codigo }}</td>
              <td class="desc">{{ row.descripcion }}</td>
              <td class="doc">{{ row.documento }}</td>
              <td class="corr">{{ row.correlativo }}</td>
              <td class="cliente">{{ row.clienteProveedor }}</td>
              <td class="num entrada-val">
                <span v-if="row.entrada > 0">+{{ formatNum(row.entrada) }}</span>
              </td>
              <td class="num salida-val">
                <span v-if="row.salida > 0">-{{ formatNum(row.salida) }}</span>
              </td>
              <td class="num">{{ row.costo > 0 ? formatMoney(row.costo) : '—' }}</td>
            </tr>
          </tbody>
          <tfoot>
            <tr class="fila-totales">
              <td colspan="6">TOTALES</td>
              <td class="num entrada-val">+{{ formatNum(resumen.totalEntradas) }}</td>
              <td class="num salida-val">-{{ formatNum(resumen.totalSalidas) }}</td>
              <td></td>
            </tr>
          </tfoot>
        </table>
      </div>
    </div>

    <!-- Empty state -->
    <div v-else-if="!cargando && buscado" class="empty-state">
      <svg viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="1.5">
        <circle cx="11" cy="11" r="8"/><line x1="21" y1="21" x2="16.65" y2="16.65"/>
      </svg>
      <p>No se encontraron movimientos para el período seleccionado.</p>
    </div>

    <!-- Initial state -->
    <div v-else-if="!cargando && !buscado" class="initial-state">
      <svg viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="1.2">
        <path d="M3 3h18v4H3zM3 10h18v4H3zM3 17h18v4H3z"/>
      </svg>
      <p>Selecciona un rango de fechas y presiona Buscar.</p>
    </div>

  </div>
</template>

<script setup lang="ts">
import { ref, computed } from 'vue'
import axios from 'axios'
import { useAuthStore } from '@/stores/auth'
 import api from '@/api/config'
const auth = useAuthStore()


const empresaNombre  = ref(auth.empresa || 'CloudPocket')
const cargando       = ref(false)
const buscado        = ref(false)
const busqueda       = ref('')
const ordenarPor     = ref('fecha_desc')
const kardexData     = ref<any[]>([])
const kardexOriginal = ref<any[]>([])

let debounceTimer: ReturnType<typeof setTimeout>

const filtros = ref({
  desde: new Date(new Date().getFullYear(), 0, 1).toISOString().split('T')[0],
  hasta: new Date().toISOString().split('T')[0]
})

const hayDatos = computed(() => kardexData.value.length > 0)

const resumen = computed(() => {
  const data = kardexData.value
  return {
    totalEntradas:   data.reduce((s, r) => s + (r.entrada || 0), 0),
    totalSalidas:    data.reduce((s, r) => s + (r.salida  || 0), 0),
    totalMovimientos: data.length,
    totalProductos:  new Set(data.map(r => r.codigo)).size
  }
})

const buscarKardex = async () => {
  cargando.value = true
  buscado.value  = true
  try {

    const res = await api.get('/api/kardex/general', {
      params: {
        desde: filtros.value.desde,
        hasta: filtros.value.hasta,
        q:     busqueda.value || undefined
      },
      headers: { Authorization: `Bearer ${auth.token}` }
    })
    kardexOriginal.value = res.data
    kardexData.value     = [...res.data]
    ordenar()
  } catch (e) {
    console.error('Error cargando Kardex General:', e)
    kardexData.value = []
  } finally {
    cargando.value = false
  }
}

const ejecutarBusqueda = () => {
  clearTimeout(debounceTimer)
  debounceTimer = setTimeout(() => {
    if (buscado.value) buscarKardex()
  }, 300)
}

const ordenar = () => {
  const data = [...kardexData.value]
  if (ordenarPor.value === 'fecha_desc') {
    data.sort((a, b) => new Date(b.fecha).getTime() - new Date(a.fecha).getTime())
  } else if (ordenarPor.value === 'fecha_asc') {
    data.sort((a, b) => new Date(a.fecha).getTime() - new Date(b.fecha).getTime())
  } else if (ordenarPor.value === 'codigo') {
    data.sort((a, b) => (a.codigo || '').localeCompare(b.codigo || ''))
  }
  kardexData.value = data
}

const exportarExcel = async () => {
  try {
    const res = await api.get('/api/kardex/general/excel', {
      params: { desde: filtros.value.desde, hasta: filtros.value.hasta, q: busqueda.value || undefined },
      headers: { Authorization: `Bearer ${auth.token}` },
      responseType: 'blob'
    })
    const url = URL.createObjectURL(new Blob([res.data]))
    const a = document.createElement('a')
    a.href = url
    a.download = `KardexGeneral_${filtros.value.desde}_${filtros.value.hasta}.xlsx`
    a.click()
  } catch (e) { console.error('Error Excel', e) }
}

const exportarPDF = async () => {
  try {
    const res = await api.get('/api/kardex/general/pdf', {
      params: { desde: filtros.value.desde, hasta: filtros.value.hasta, q: busqueda.value || undefined },
      headers: { Authorization: `Bearer ${auth.token}` },
      responseType: 'blob'
    })
    const url = URL.createObjectURL(new Blob([res.data], { type: 'application/pdf' }))
    window.open(url, '_blank')
  } catch (e) { console.error('Error PDF', e) }
}

const formatFecha = (f: string) => {
  if (!f) return ''
  return new Date(f).toLocaleDateString('es-SV', { day: '2-digit', month: '2-digit', year: 'numeric' })
}
const formatNum   = (n: number) => (n || 0).toLocaleString('es-SV', { minimumFractionDigits: 2, maximumFractionDigits: 2 })
const formatMoney = (n: number) => `$${(n || 0).toLocaleString('es-SV', { minimumFractionDigits: 2 })}`
</script>

<style scoped>
.kardex-root {
  padding: 24px;
  min-height: 100vh;
  background: #f5f5f7;
  font-family: 'SF Pro Display', -apple-system, sans-serif;
}

.page-header {
  display: flex; align-items: center; justify-content: space-between;
  margin-bottom: 20px;
}
.header-left { display: flex; align-items: center; gap: 14px; }
.header-icon {
  width: 44px; height: 44px; background: #1d1d1f;
  border-radius: 12px; display: flex; align-items: center; justify-content: center;
}
.header-icon svg { width: 20px; height: 20px; stroke: white; }
.page-title { font-size: 22px; font-weight: 700; color: #1d1d1f; margin: 0; }
.page-sub { font-size: 12px; color: #86868b; margin: 2px 0 0; }

.header-actions { display: flex; gap: 8px; }
.btn-export {
  display: flex; align-items: center; gap: 6px;
  padding: 8px 16px; border-radius: 10px;
  font-size: 13px; font-weight: 500; border: none; cursor: pointer; transition: all 0.15s;
}
.btn-export svg { width: 14px; height: 14px; }
.btn-export.excel { background: #e8f5e9; color: #2e7d32; }
.btn-export.excel:hover { background: #2e7d32; color: white; }
.btn-export.pdf { background: #fce4ec; color: #c62828; }
.btn-export.pdf:hover { background: #c62828; color: white; }
.btn-export:disabled { opacity: 0.4; cursor: not-allowed; }

.filtros-card {
  background: white; border-radius: 16px; padding: 20px; margin-bottom: 16px;
  box-shadow: 0 1px 3px rgba(0,0,0,0.06); border: 1px solid rgba(0,0,0,0.06);
}
.filtros-grid {
  display: grid;
  grid-template-columns: 1fr 160px 160px auto;
  gap: 16px; align-items: end;
}
.filtro-group { display: flex; flex-direction: column; gap: 6px; }
.filtro-group label { font-size: 11px; font-weight: 600; color: #86868b; text-transform: uppercase; letter-spacing: 0.5px; }
.filtro-group input {
  padding: 9px 12px; border-radius: 10px;
  border: 1px solid rgba(0,0,0,0.1); background: rgba(0,0,0,0.03);
  font-size: 13px; color: #1d1d1f; outline: none; transition: all 0.15s;
}
.filtro-group input:focus {
  border-color: #0071e3;
  box-shadow: 0 0 0 3px rgba(0,113,227,0.12);
}
.search-wrap { position: relative; }
.search-wrap input { width: 100%; padding-right: 36px; box-sizing: border-box; }
.search-icon { position: absolute; right: 10px; top: 50%; transform: translateY(-50%); width: 16px; height: 16px; stroke: #86868b; pointer-events: none; }

.btn-buscar {
  display: flex; align-items: center; gap: 8px;
  padding: 10px 24px; border-radius: 10px;
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
  display: grid; grid-template-columns: repeat(4, 1fr);
  gap: 12px; margin-bottom: 16px;
}
.kpi-card {
  background: white; border-radius: 14px; padding: 16px 18px;
  display: flex; align-items: center; gap: 14px;
  box-shadow: 0 1px 3px rgba(0,0,0,0.06); border: 1px solid rgba(0,0,0,0.06);
}
.kpi-icon { width: 40px; height: 40px; border-radius: 10px; display: flex; align-items: center; justify-content: center; flex-shrink: 0; }
.kpi-icon svg { width: 18px; height: 18px; }
.kpi-card.entradas .kpi-icon { background: #e8f5e9; }
.kpi-card.entradas .kpi-icon svg { stroke: #2e7d32; }
.kpi-card.salidas .kpi-icon { background: #fce4ec; }
.kpi-card.salidas .kpi-icon svg { stroke: #c62828; }
.kpi-card.productos .kpi-icon { background: #e3f2fd; }
.kpi-card.productos .kpi-icon svg { stroke: #1565c0; }
.kpi-card.movimientos .kpi-icon { background: #f3e5f5; }
.kpi-card.movimientos .kpi-icon svg { stroke: #6a1b9a; }
.kpi-data { display: flex; flex-direction: column; }
.kpi-label { font-size: 11px; color: #86868b; font-weight: 500; }
.kpi-value { font-size: 20px; font-weight: 700; color: #1d1d1f; }

.tabla-card {
  background: white; border-radius: 16px; overflow: hidden;
  box-shadow: 0 1px 3px rgba(0,0,0,0.06); border: 1px solid rgba(0,0,0,0.06);
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
td.fecha { color: #86868b; font-size: 12px; white-space: nowrap; }
td.codigo { font-weight: 700; font-size: 12px; color: #0071e3; white-space: nowrap; }
td.desc { font-size: 12px; max-width: 200px; overflow: hidden; text-overflow: ellipsis; white-space: nowrap; }
td.doc { font-size: 12px; color: #555; }
td.corr { font-size: 12px; font-weight: 600; }
td.cliente { font-size: 12px; max-width: 180px; overflow: hidden; text-overflow: ellipsis; white-space: nowrap; }

.entrada-val { color: #2e7d32; font-weight: 600; }
.salida-val  { color: #c62828; font-weight: 600; }
.row-entrada { background: rgba(46,125,50,0.02); }
.row-salida  { background: rgba(198,40,40,0.02); }
tr:hover td  { background: rgba(0,0,0,0.02); }

tfoot .fila-totales td {
  padding: 12px 14px; background: #f5f5f7;
  font-weight: 700; font-size: 13px;
  border-top: 2px solid rgba(0,0,0,0.08);
}

.empty-state, .initial-state {
  display: flex; flex-direction: column; align-items: center; justify-content: center;
  padding: 60px 20px; gap: 12px;
  background: white; border-radius: 16px; border: 1px solid rgba(0,0,0,0.06);
}
.empty-state svg, .initial-state svg { width: 48px; height: 48px; stroke: #c7c7cc; }
.empty-state p,   .initial-state p   { font-size: 14px; color: #86868b; margin: 0; }

@media (max-width: 768px) {
  .filtros-grid { grid-template-columns: 1fr; }
  .kpis-row { grid-template-columns: repeat(2, 1fr); }
  .header-actions { display: none; }
}
</style>