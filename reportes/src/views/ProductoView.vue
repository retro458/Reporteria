<template>
    <div class="p-6 bg-slate-50 min-h-screen">
      <div class="mb-6 flex justify-between items-end">
        <div>
          <h1 class="text-2xl font-black text-slate-800">Existencias</h1>
          <p class="text-slate-500 text-sm italic">Control de inventario físico y teórico</p>
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


      <div class="grid grid-cols-1 md:grid-cols-5 gap-4 mb-6 items-center"> <div class="md:col-span-2">
    <input 
      v-model="busqueda" 
      type="text" 
      placeholder="Buscar por código o descripción..." 
      class="w-full px-6 py-4 rounded-2xl border-none shadow-sm focus:ring-2 focus:ring-blue-500 outline-none text-slate-600"
    />
  </div>

  <select v-model="catSeleccionada" class="px-4 py-4 rounded-2xl border-none shadow-sm bg-white outline-none font-bold text-slate-500">
    <option value="TODAS">TODAS LAS CATEGORÍAS</option>
    <option v-for="cat in categorias" :key="cat" :value="cat">{{ cat }}</option>
  </select> 

  <select v-model="ordenarPor" class="px-4 py-4 rounded-2xl border-none shadow-sm bg-white outline-none font-bold text-slate-500">
    <option value="codigo">ORDENAR POR CÓDIGO</option>
    <option value="descripcion">ORDENAR POR NOMBRE</option>
    <option value="existencia">POR EXISTENCIA</option>
  </select>

  <div class="flex items-center justify-center bg-white py-4 px-4 rounded-2xl shadow-sm cursor-pointer hover:bg-slate-50 transition-colors"
       @click="soloConExistencia = !soloConExistencia">
    <div :class="soloConExistencia ? 'bg-blue-600' : 'bg-slate-200'" 
         class="w-10 h-5 rounded-full relative transition-colors mr-3">
      <div :class="soloConExistencia ? 'translate-x-5' : 'translate-x-0'"
           class="absolute top-0.5 left-0.5 w-4 h-4 bg-white rounded-full transition-transform shadow-sm"></div>
    </div>
    <span class="text-[11px] font-black text-slate-500 uppercase select-none">Solo Stock</span>
  </div>
</div>
  
      <div class="bg-white rounded-[2rem] shadow-sm border border-slate-100 overflow-hidden">
        <table class="w-full">
          <thead class="bg-slate-50/50">
            <tr>
              <th class="p-5 text-left text-[10px] font-black text-slate-400 uppercase">Información del Producto</th>
              <th class="p-5 text-center text-[10px] font-black text-slate-400 uppercase">Categoría</th>
              <th class="p-5 text-right text-[10px] font-black text-slate-400 uppercase">Existencia</th>
              <th class="p-5 text-right text-[10px] font-black text-slate-400 uppercase">Precio Unit.</th>
              <th class="p-5 text-center text-[10px] font-black text-slate-400 uppercase">Estado</th>
            </tr>
          </thead>
          <tbody class="divide-y divide-slate-50">
            <tr v-for="p in productosFiltrados" :key="p.codigo" class="hover:bg-slate-50/80 transition-all cursor-default">
              <td class="p-5">
                <div class="text-blue-600 font-black text-sm mb-1">{{ p.codigo }}</div>
                <div class="text-slate-700 font-medium text-xs uppercase">{{ p.descripcion }}</div>
              </td>
              <td class="p-5 text-center">
                <span class="text-[10px] font-bold bg-slate-100 text-slate-500 px-3 py-1 rounded-lg">
                  {{ p.categoria }}
                </span>
              </td>
              <td class="p-5 text-right">
                <div class="text-sm font-black text-slate-800">{{ p.existencia }}</div>
                <div class="text-[9px] text-slate-400 font-bold uppercase">{{ p.unidadMedida }}</div>
              </td>
              <td class="p-5 text-right text-sm font-black text-slate-700">
                ${{ p.precioVenta.toFixed(2) }}
              </td>
              <td class="p-5 text-center">
                <span :class="statusColor(p)" class="text-[9px] font-black uppercase px-3 py-1.5 rounded-full shadow-sm">
                  {{ statusText(p) }}
                </span>
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>
  </template>
  
  <script setup>
  import { ref, computed, onMounted } from 'vue'
  import api from '@/api/config'
   import axios from 'axios'
  import { useAuthStore } from '@/stores/auth'
  const auth = useAuthStore()
  
  const busqueda = ref('')
  const catSeleccionada = ref('TODAS')
  const soloConExistencia = ref(false)
  const productos = ref([])
  const ordenarPor = ref('codigo')
  const hayDatos = computed(() => productosFiltrados.value.length > 0)
  const cargarStock = async () => {
    const res = await api.get('/api/Kardex/stock-productos')
    productos.value = res.data
  }
  
  const categorias = computed(() => {
    return [...new Set(productos.value.map(p => p.categoria))]
  })
  
  const productosFiltrados = computed(() => {
  // 1. Filtrado (Búsqueda, Categoría, Existencia)
  let filtrados = productos.value.filter(p => {
    const matchBusqueda = (p.descripcion?.toLowerCase().includes(busqueda.value.toLowerCase()) || 
                          p.codigo?.toLowerCase().includes(busqueda.value.toLowerCase()))
    
    const matchCat = catSeleccionada.value === 'TODAS' || p.categoria === catSeleccionada.value
    const matchExistencia = !soloConExistencia.value || (p.existencia > 0)
    
    return matchBusqueda && matchCat && matchExistencia
  })

  // 2. ORDENAMIENTO DINÁMICO
  return filtrados.sort((a, b) => {
    if (ordenarPor.value === 'codigo') {
      return (a.codigo || '').localeCompare(b.codigo || '')
    } else if (ordenarPor.value === 'descripcion') {
      return (a.descripcion || '').localeCompare(b.descripcion || '')
    } else if (ordenarPor.value === 'existencia') {
      return a.existencia - b.existencia
    }
    return 0
  })
})
  const statusColor = (p) => {
    if (p.existencia <= 0) return 'bg-red-50 text-red-500 border border-red-100'
    if (p.existencia <= p.stockMinimo) return 'bg-amber-50 text-amber-500 border border-amber-100'
    return 'bg-green-50 text-green-500 border border-green-100'
  }
  
  const statusText = (p) => {
    if (p.existencia <= 0) return 'Sin Stock'
    if (p.existencia <= p.stockMinimo) return 'Bajo Mínimo'
    return 'Óptimo'
  }

  // btn exportar pdf y excel
  // --- Exportaciones ---
  const exportarExcel = async () => {
  try {
    const res = await api.get('/api/kardex/stock/excel', {
      params: { 
        // ENVIAR TODOS LOS FILTROS ACTUALES
        q: busqueda.value || undefined,
        categoria: catSeleccionada.value === 'TODAS' ? undefined : catSeleccionada.value,
        estado: soloConExistencia.value ? "true" : "false",
        sort: ordenarPor.value
      },
      headers: { Authorization: `Bearer ${auth.token}` },
      responseType: 'blob' 
    })

    // Crear el link de descarga
    const blob = new Blob([res.data], { type: 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet' })
    const url = URL.createObjectURL(blob)
    
    const a = document.createElement('a')
    a.href = url
    a.download = `Stock_${new Date().toISOString().split('T')[0]}.xlsx`
    
    document.body.appendChild(a) // Añadir temporalmente al DOM
    a.click()
    
    // Limpieza
    document.body.removeChild(a)
    URL.revokeObjectURL(url) 
    
  } catch (e) { 
    console.error('Error al exportar Excel:', e) 
    
  }
}

const exportarPDF = async () => {
  try {
    const res = await api.get('/api/kardex/stock/pdf', {
      params: { 
        q: busqueda.value || undefined,
        categoria: catSeleccionada.value === 'TODAS' ? undefined : catSeleccionada.value,
        estado: soloConExistencia.value ? "true" : "false",
        sort: ordenarPor.value 
      },
      headers: { Authorization: `Bearer ${auth.token}` },
      responseType: 'blob' 
    })

    // Crear el Blob con el tipo MIME correcto
    const blob = new Blob([res.data], { type: 'application/pdf' })
    
    // Generar la URL temporal
    const url = URL.createObjectURL(blob)

    // Abrir en pestaña nueva
    // se usa '_blank' para que no reemplace al dominio
    window.open(url, '_blank')

    // no se borra la URL inmediatamente. 
    // Si se borras en 1 segundo, a veces el PDF no termina de cargar y sale error.
    // Déjarla viva un rato largo o no borrear (el navegador la limpia al cerrar la pestaña).
    setTimeout(() => URL.revokeObjectURL(url), 80000) // 80 segundos
    
  } catch (e) {
    console.error('Error al generar PDF:', e)
    // Opcional: una alerta simple si falla la API
    alert("No se pudo generar el PDF. Revisa la consola.")
  }
}
  
  onMounted(cargarStock)
  </script>

<style>
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
</style>