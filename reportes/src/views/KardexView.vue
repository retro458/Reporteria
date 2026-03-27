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
          <h1 class="page-title">Kardex de Inventario</h1>
          <p class="page-sub">Movimientos por producto · {{ empresaNombre }}</p>
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
          <label>Producto</label>
          <div class="search-wrap">
            <input
              v-model="busquedaProducto"
              type="text"
              placeholder="Buscar por código o nombre..."
              @input="buscarProductos"
              @focus="showDropdown = true"
              autocomplete="off"
            />
            <svg class="search-icon" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2">
              <circle cx="11" cy="11" r="8"/><line x1="21" y1="21" x2="16.65" y2="16.65"/>
            </svg>
            <!-- Dropdown resultados -->
            <div 
             v-if="showDropdown && productosEncontrados.length > 0" 
             class="dropdown-productos"
             @mouseenter="cancelClose"
             @mouseleave="handleClickOutside"
             >
            <div
             v-for="p in productosEncontrados"
             :key="p.codigo"
             class="dropdown-item"
             @mousedown="seleccionarProducto(p)"
             >
             <span class="prod-code">{{ p.codigo }}</span>
             <span class="prod-name">{{ p.nombre }}</span>
              </div>
             </div>
          </div>
          <!-- Producto seleccionado -->
          <div v-if="productoSeleccionado" class="prod-badge">
            <span>{{ productoSeleccionado.codigo }} — {{ productoSeleccionado.nombre }}</span>
            <button @click="limpiarProducto">×</button>
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
          <button class="btn-buscar" @click="buscarKardex" :disabled="cargando || !productoSeleccionado">
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
      <div class="kpi-card saldo">
        <div class="kpi-icon">
          <svg viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2"><rect x="2" y="3" width="20" height="14" rx="2"/><line x1="8" y1="21" x2="16" y2="21"/><line x1="12" y1="17" x2="12" y2="21"/></svg>
        </div>
        <div class="kpi-data">
          <span class="kpi-label">Saldo Final</span>
          <span class="kpi-value">{{ formatNum(resumen.saldoFinal) }}</span>
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

    <!-- Tabla Kardex -->
    <div v-if="hayDatos" class="tabla-card">
      <div class="tabla-header">
        <h3>Detalle de Movimientos</h3>
        <span class="tabla-count">{{ kardexData.length }} registros</span>
      </div>
      <div class="tabla-scroll">
        <table>
          <thead>
            <tr>
              <th>Fecha</th>
              <th>Documento</th>
              <th>Correlativo</th>
              <th>Cliente / Proveedor</th>
              <th class="num">Entrada</th>
              <th class="num">Salida</th>
              <th class="num saldo-col">Saldo</th>
              <th class="num">Costo Unit.</th>
            </tr>
          </thead>
          <tbody>
            <!-- Saldo inicial -->
            <tr class="row-saldo-ini">
              <td colspan="6" class="saldo-ini-label">Saldo Inicial al {{ filtros.desde }}</td>
              <td class="num saldo-col"><strong>{{ formatNum(resumen.saldoInicial) }}</strong></td>
              <td></td>
            </tr>
            <tr
              v-for="(row, i) in kardexData"
              :key="i"
              :class="{ 'row-entrada': row.entrada > 0, 'row-salida': row.salida > 0 }"
            >
              <td class="fecha">{{ formatFecha(row.fecha) }}</td>
              <td class="doc">{{ row.documento }}</td>
              <td class="corr">{{ row.correlativo }}</td>
              <td class="cliente">{{ row.clienteProveedor }}</td>
              <td class="num entrada-val">
                <span v-if="row.entrada > 0">+{{ formatNum(row.entrada) }}</span>
              </td>
              <td class="num salida-val">
                <span v-if="row.salida > 0">-{{ formatNum(row.salida) }}</span>
              </td>
              <td class="num saldo-col">{{ formatNum(row.saldo) }}</td>
              <td class="num">{{ row.costo > 0 ? formatMoney(row.costo) : '—' }}</td>
            </tr>
          </tbody>
          <tfoot>
            <tr class="fila-totales">
              <td colspan="4">TOTALES</td>
              <td class="num entrada-val">+{{ formatNum(resumen.totalEntradas) }}</td>
              <td class="num salida-val">-{{ formatNum(resumen.totalSalidas) }}</td>
              <td class="num saldo-col"><strong>{{ formatNum(resumen.saldoFinal) }}</strong></td>
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
        <path d="M3 3h18v4H3zM3 10h18v4H3zM3 17h11v4H3z"/>
        <circle cx="19" cy="19" r="3"/><line x1="21" y1="21" x2="22" y2="22"/>
      </svg>
      <p>Selecciona un producto y rango de fechas para ver el kardex.</p>
    </div>

  </div>
</template>

<script setup lang="ts">
import { ref, computed, onMounted } from 'vue'
import axios from 'axios'
import { useAuthStore } from '@/stores/auth'
import api from '@/api/config'
const auth = useAuthStore()


// Estado
const busquedaProducto = ref('')
const productoSeleccionado = ref<{codigo: string, nombre: string} | null>(null)
const productosEncontrados = ref<{codigo: string, nombre: string}[]>([])
const showDropdown = ref(false)
const cargando = ref(false)
const buscado = ref(false)
const kardexData = ref<any[]>([])
const empresaNombre = ref(auth.empresa || 'CloudPocket')
const saldoInicialReal = ref(0)
const filtros = ref({
  desde: new Date(new Date().getFullYear(), 0, 1).toISOString().split('T')[0],
  hasta: new Date().toISOString().split('T')[0]
})

// Computed
const hayDatos = computed(() => kardexData.value.length > 0)

const resumen = computed(() => {
  let totalEntradas = 0
  let totalSalidas = 0

  // Sumamos entradas y salidas del periodo
  kardexData.value.forEach(r => {
    totalEntradas += r.entrada || 0
    totalSalidas += r.salida || 0
  })

  // Calcular saldo acumulado
  let runningSaldo = saldoInicialReal.value
  kardexData.value.forEach(r => {
    runningSaldo += (r.entrada || 0) - (r.salida || 0)
    r.saldo = runningSaldo // Inyectamos el saldo calculado en cada fila
  })

  return {
    totalEntradas,
    totalSalidas,
    saldoFinal: runningSaldo,
    saldoInicial: saldoInicialReal.value,
    totalMovimientos: kardexData.value.length
  }
})

// Métodos
const buscarProductos = async () => {
  if (busquedaProducto.value.length < 2) {
    productosEncontrados.value = []
    return
  }
  try {
    // Usar 'api' directamente
    const res = await api.get('/api/kardex/productos', {
      params: { q: busquedaProducto.value },
      headers: { Authorization: `Bearer ${auth.token}` }
    })
    productosEncontrados.value = res.data
  } catch (e) {
    //console.error('Error buscando productos', e)
    productosEncontrados.value = [] 
  }
}

const seleccionarProducto = (p: {codigo: string, nombre: string}) => {
  productoSeleccionado.value = p
  busquedaProducto.value = ''
  showDropdown.value = false
  productosEncontrados.value = []
}

const limpiarProducto = () => {
  productoSeleccionado.value = null
  kardexData.value = []
  buscado.value = false
}

const buscarKardex = async () => {
  if (!productoSeleccionado.value) return
  cargando.value = true
  buscado.value = true
  try {
    const res = await api.get('/api/kardex', {
      params: {
        codigo: productoSeleccionado.value.codigo,
        desde: filtros.value.desde,
        hasta: filtros.value.hasta
      }
    })

    // ambas formas (Mayúscula y Minúscula)
    kardexData.value = res.data.movimientos || res.data.Movimientos || []
    saldoInicialReal.value = res.data.saldoInicial || res.data.SaldoInicial || 0
    
  } catch (e) {
   // console.error('Error cargando Kardex', e)
    kardexData.value = []
    saldoInicialReal.value = 0
  } finally {
    cargando.value = false
  }
}

const exportarExcel = async () => {
  if (!productoSeleccionado.value) return
  try {
    const res = await api.get('/api/kardex/excel', {
      params: {
        codigo: productoSeleccionado.value.codigo,
        desde: filtros.value.desde,
        hasta: filtros.value.hasta
      },
      headers: { Authorization: `Bearer ${auth.token}` },
      responseType: 'blob'
    })
    const url = URL.createObjectURL(new Blob([res.data]))
    const a = document.createElement('a')
    a.href = url
    a.download = `Kardex_${productoSeleccionado.value.codigo}.xlsx`
    a.click()
  } catch (e) {
    //console.error('Error generando Excel', e)
  }
}

const exportarPDF = async () => {
  if (!productoSeleccionado.value) return
  try {
    const res = await api.get('/api/kardex/pdf', {
      params: {
        codigo: productoSeleccionado.value.codigo,
        desde: filtros.value.desde,
        hasta: filtros.value.hasta
      },
      headers: { Authorization: `Bearer ${auth.token}` },
      responseType: 'blob'
    })
    const url = URL.createObjectURL(new Blob([res.data], { type: 'application/pdf' }))
    window.open(url, '_blank')
  } catch (e) {
   // console.error('Error generando PDF', e)
  }
}

// Formatters
const formatFecha = (f: string) => {
  if (!f) return ''
  return new Date(f).toLocaleDateString('es-SV', { day: '2-digit', month: '2-digit', year: 'numeric' })
}
const formatNum = (n: number) => (n || 0).toLocaleString('es-SV', { minimumFractionDigits: 2, maximumFractionDigits: 2 })
const formatMoney = (n: number) => `$${(n || 0).toLocaleString('es-SV', { minimumFractionDigits: 2 })}`

// Cerrar dropdown al hacer click fuera
let closeTimer: ReturnType<typeof setTimeout>

const handleClickOutside = () => {
  closeTimer = setTimeout(() => {
    showDropdown.value = false
  }, 200) // delay para que el mousedown del item se registre primero
}

const cancelClose = () => {
  clearTimeout(closeTimer)
}

onMounted(async () => {
  document.addEventListener('click', (e) => {
    const wrap = document.querySelector('.search-wrap')
    if (wrap && !wrap.contains(e.target as Node)) {
      showDropdown.value = false
    }
  })
})
</script>

<style scoped>
.kardex-root {
  padding: 24px;
  min-height: 100vh;
  background: #f5f5f7;
  font-family: 'SF Pro Display', -apple-system, sans-serif;
}

/* Header */
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

/* Filtros */
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
  grid-template-columns: 1fr 160px 160px auto;
  gap: 16px;
  align-items: end;
}
.filtro-group { display: flex; flex-direction: column; gap: 6px; }
.filtro-group label { font-size: 11px; font-weight: 600; color: #86868b; text-transform: uppercase; letter-spacing: 0.5px; }
.filtro-group input[type="text"],
.filtro-group input[type="date"] {
  padding: 9px 12px;
  border-radius: 10px;
  border: 1px solid rgba(0,0,0,0.1);
  background: rgba(0,0,0,0.03);
  font-size: 13px; color: #1d1d1f;
  outline: none; transition: all 0.15s;
}
.filtro-group input:focus {
  border-color: #0071e3;
  box-shadow: 0 0 0 3px rgba(0,113,227,0.12);
}

.search-wrap { position: relative; }
.search-wrap input { width: 100%; padding-right: 36px; box-sizing: border-box; }
.search-icon { position: absolute; right: 10px; top: 50%; transform: translateY(-50%); width: 16px; height: 16px; stroke: #86868b; pointer-events: none; }

.dropdown-productos {
  position: absolute; top: calc(100% + 4px); left: 0; right: 0;
  background: white; border-radius: 12px;
  box-shadow: 0 8px 24px rgba(0,0,0,0.12);
  border: 1px solid rgba(0,0,0,0.08);
  z-index: 100; max-height: 200px; overflow-y: auto;
}
.dropdown-item {
  display: flex; align-items: center; gap: 10px;
  padding: 10px 14px; cursor: pointer; transition: background 0.1s;
}
.dropdown-item:hover { background: #f5f5f7; }
.prod-code { font-size: 11px; font-weight: 700; color: #0071e3; background: rgba(0,113,227,0.08); padding: 2px 7px; border-radius: 6px; }
.prod-name { font-size: 13px; color: #1d1d1f; }

.prod-badge {
  display: flex; align-items: center; justify-content: space-between;
  background: rgba(0,113,227,0.08); border-radius: 8px;
  padding: 6px 10px; margin-top: 4px;
  font-size: 12px; color: #0071e3; font-weight: 500;
}
.prod-badge button { background: none; border: none; color: #0071e3; cursor: pointer; font-size: 16px; line-height: 1; }

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

/* KPIs */
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
.kpi-icon {
  width: 40px; height: 40px; border-radius: 10px;
  display: flex; align-items: center; justify-content: center; flex-shrink: 0;
}
.kpi-icon svg { width: 18px; height: 18px; }
.kpi-card.entradas .kpi-icon { background: #e8f5e9; }
.kpi-card.entradas .kpi-icon svg { stroke: #2e7d32; }
.kpi-card.salidas .kpi-icon { background: #fce4ec; }
.kpi-card.salidas .kpi-icon svg { stroke: #c62828; }
.kpi-card.saldo .kpi-icon { background: #e3f2fd; }
.kpi-card.saldo .kpi-icon svg { stroke: #1565c0; }
.kpi-card.movimientos .kpi-icon { background: #f3e5f5; }
.kpi-card.movimientos .kpi-icon svg { stroke: #6a1b9a; }
.kpi-data { display: flex; flex-direction: column; }
.kpi-label { font-size: 11px; color: #86868b; font-weight: 500; }
.kpi-value { font-size: 20px; font-weight: 700; color: #1d1d1f; }

/* Tabla */
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
.tabla-count { font-size: 12px; color: #86868b; background: #f5f5f7; padding: 3px 10px; border-radius: 20px; }

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
td.doc { font-size: 12px; color: #555; }
td.corr { font-size: 12px; font-weight: 600; }
td.cliente { font-size: 12px; max-width: 200px; overflow: hidden; text-overflow: ellipsis; white-space: nowrap; }

.saldo-col { font-weight: 600; }
.entrada-val { color: #2e7d32; font-weight: 600; }
.salida-val { color: #c62828; font-weight: 600; }

.row-entrada { background: rgba(46,125,50,0.02); }
.row-salida { background: rgba(198,40,40,0.02); }
tr:hover td { background: rgba(0,0,0,0.02); }

.row-saldo-ini td { background: #fff8e1; font-size: 12px; }
.saldo-ini-label { color: #f57f17; font-weight: 600; font-style: italic; }

tfoot .fila-totales td {
  padding: 12px 14px;
  background: #f5f5f7;
  font-weight: 700; font-size: 13px;
  border-top: 2px solid rgba(0,0,0,0.08);
}

/* States */
.empty-state, .initial-state {
  display: flex; flex-direction: column; align-items: center; justify-content: center;
  padding: 60px 20px; gap: 12px;
  background: white; border-radius: 16px;
  border: 1px solid rgba(0,0,0,0.06);
}
.empty-state svg, .initial-state svg { width: 48px; height: 48px; stroke: #c7c7cc; }
.empty-state p, .initial-state p { font-size: 14px; color: #86868b; margin: 0; }

@media (max-width: 768px) {
  .filtros-grid { grid-template-columns: 1fr; }
  .kpis-row { grid-template-columns: repeat(2, 1fr); }
  .header-actions { display: none; }
}
</style>