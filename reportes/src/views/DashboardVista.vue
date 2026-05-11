<template>
  <div class="dashboard-container bg-[#fcfdfe] min-h-screen p-8">
    
    <div class="flex justify-between items-center mb-12 pb-6 border-b border-slate-100">
      <div>
        <h1 class="text-3xl font-black text-slate-950 tracking-tighter">Resumen Operativo</h1>
        <p class="text-slate-500 text-sm mt-1">Monitoreo de inventario y ventas en tiempo real</p>
      </div>
      <div class="flex gap-2">
        <span class="inline-flex items-center px-4 py-1.5 rounded-full text-xs font-semibold bg-emerald-50 text-emerald-800 shadow-sm">
          <span class="w-2.5 h-2.5 mr-2 bg-emerald-500 rounded-full animate-pulse border-2 border-white"></span>
          Sistema en vivo
        </span>
      </div>
    </div>

    <div class="grid grid-cols-1 md:grid-cols-3 gap-8 mb-12">
      
      <div class="bg-white rounded-3xl p-6 border border-slate-100 shadow-xl shadow-slate-100/50 overflow-hidden relative transition hover:border-emerald-100">
        <div class="flex justify-between items-start mb-1">
          <div>
            <p class="text-slate-500 text-[10px] font-bold uppercase tracking-widest">Ingreso Real (Sin IVA)</p>
            <h2 class="text-3xl font-black text-emerald-950 mt-1">${{ formatNum(stats.totales.ventasNetas) }}</h2>
          </div>
          <span class="text-emerald-600 bg-emerald-50 text-[10px] font-bold px-3 py-1.5 rounded-xl">Neto</span>
        </div>
        <div class="absolute inset-x-0 bottom-0">
          <apexchart v-if="!cargando" type="area" height="70" :options="sparkOptions('#10b981')" :series="[{ data: stats.datosGrafica.map(i => i.totalNeto) }]"></apexchart>
        </div>
      </div>

      <div class="bg-white rounded-3xl p-6 border border-slate-100 shadow-xl shadow-slate-100/50 overflow-hidden relative transition hover:border-amber-100">
        <div class="flex justify-between items-start mb-1">
          <div>
            <p class="text-slate-500 text-[10px] font-bold uppercase tracking-widest">IVA Acumulado (13%)</p>
            <h2 class="text-3xl font-black text-amber-950 mt-1">${{ formatNum(stats.totales.ivaAcumulado) }}</h2>
          </div>
          <span class="text-amber-700 bg-amber-50 text-[10px] font-bold px-3 py-1.5 rounded-xl">Obligación</span>
        </div>
        <div class="absolute inset-x-0 bottom-0">
          <apexchart v-if="!cargando" type="area" height="70" :options="sparkOptions('#f59e0b')" :series="[{ data: stats.datosGrafica.map(i => i.totalIVA) }]"></apexchart>
        </div>
      </div>

      <div class="bg-blue-600 rounded-3xl p-6 text-white shadow-2xl shadow-blue-200 overflow-hidden relative group">
        <div class="relative z-10 flex justify-between items-start mb-1">
          <div>
            <p class="text-blue-100 text-[10px] font-bold uppercase tracking-widest">Total Recaudado (Con IVA)</p>
            <h2 class="text-3xl font-black mt-1 tracking-tight">${{ formatNum(stats.totales.ventasBrutas) }}</h2>
          </div>
        </div>
        <div class="absolute inset-x-0 bottom-0 opacity-20 group-hover:opacity-30 transition">
          <apexchart v-if="!cargando" type="area" height="70" :options="sparkOptions('#ffffff', true)" :series="[{ data: stats.datosGrafica.map(i => i.totalBruto) }]"></apexchart>
        </div>
      </div>
    </div>
    <div class="grid grid-cols-1 lg:grid-cols-[2fr,1fr] gap-8">
  <div class="bg-white rounded-3xl p-8 border border-slate-100 shadow-xl shadow-slate-100/50">
    <h3 class="text-sm font-bold text-slate-800 mb-6 uppercase tracking-wider">Fugas de Inventario (Alerta Stock Negativo)</h3>
    
    <div v-if="stats.topFugas && stats.topFugas.length > 0" class="space-y-3">
      <div v-for="item in stats.topFugas" :key="item.codigo" 
           class="flex justify-between items-center p-4 rounded-2xl hover:bg-slate-50 transition-all border border-transparent hover:border-slate-100 group">
        <div class="flex items-center gap-4">
          <div class="w-10 h-10 rounded-xl bg-red-50 flex items-center justify-center text-red-500 group-hover:scale-110 transition-transform">
            <svg class="w-5 h-5" fill="none" stroke="currentColor" viewBox="0 0 24 24">
              <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M12 9v2m0 4h.01m-6.938 4h13.856c1.54 0 2.502-1.667 1.732-3L13.732 4c-.77-1.333-2.694-1.333-3.464 0L3.34 16c-.77 1.333.192 3 1.732 3z"/>
            </svg>
          </div>
          <div>
            <p class="text-sm font-bold text-slate-900 leading-none">{{ item.descripcion }}</p>
            <p class="text-[10px] text-slate-400 mt-1.5 font-mono uppercase tracking-tight">{{ item.codigo }}</p>
          </div>
        </div>
        <div class="text-right">
          <span class="inline-flex items-center px-3 py-1.5 rounded-xl text-xs font-black bg-red-50 text-red-600 border border-red-100">
            {{ item.existencia }}
          </span>
        </div>
      </div>
    </div>

    <div v-else class="flex flex-col items-center justify-center py-16 text-center">
      <div class="w-16 h-16 bg-emerald-50 rounded-full flex items-center justify-center text-emerald-500 mb-4">
        <svg class="w-8 h-8" fill="none" stroke="currentColor" viewBox="0 0 24 24">
          <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M9 12l2 2 4-4m6 2a9 9 0 11-18 0 9 9 0 0118 0z"/>
        </svg>
      </div>
      <p class="text-slate-600 font-bold text-sm">Inventario Saludable</p>
      <p class="text-slate-400 text-xs mt-1">No se detectaron existencias negativas en el sistema.</p>
    </div>
  </div>

  <div class="bg-white rounded-3xl p-8 border border-slate-100 shadow-xl shadow-slate-100/50">
    <h3 class="text-sm font-bold text-slate-800 mb-6 uppercase tracking-wider">Estado del Catálogo</h3>
    <div class="grid grid-cols-1 gap-6">
       <div class="p-6 bg-slate-50 rounded-2xl border border-slate-100 transition-hover hover:bg-white hover:shadow-md">
          <p class="text-xs text-slate-500 font-bold uppercase tracking-tighter">Productos Registrados</p>
          <p class="text-4xl font-black text-slate-950 mt-2 tracking-tighter">{{ stats.totales.totalProductos }}</p>
       </div>
       <div class="p-6 bg-slate-50 rounded-2xl border border-slate-100 transition-hover hover:bg-white hover:shadow-md">
          <p class="text-xs text-slate-500 font-bold uppercase tracking-tighter">Inversión Compras (Periodo)</p>
          <p class="text-4xl font-black text-slate-950 mt-2 tracking-tighter">${{ formatNum(stats.totales.inversionComprasPeriodo) }}</p>
       </div>
    </div>
  </div>
</div>
  </div>
</template>

<script setup>
import { ref, onMounted } from 'vue'
import api from '@/api/config'

const cargando = ref(true)
const stats = ref({
  totales: { totalProductos: 0, valorVentasPeriodo: 0, inversionComprasPeriodo: 0 },
  datosGrafica: [],
  topFugas: []
})

// Configuración de ApexCharts
const sparkOptions = (color, isDark = false) => ({
  chart: {
    type: 'area',
    sparkline: { enabled: true },
    animations: {
      enabled: true,
      easing: 'linear', // Lineal es mejor para movimiento continuo
      dynamicAnimation: {
        speed: 1000 // Esto debe coincidir con la frecuencia de actualización
      }
    }
  },
  stroke: { 
    curve: 'smooth', // Crucial para el efecto de "onda"
    width: 2.5 
  },
  // Suavizamos el trazo para que la animación se vea más orgánica
  stroke: { 
    curve: 'smooth', 
    width: isDark ? 1.5 : 2.5,
    lineCap: 'round' 
  },
  fill: {
    type: 'gradient',
    gradient: {
      shadeIntensity: 1,
      opacityFrom: isDark ? 0.6 : 0.4,
      opacityTo: 0,
    }
  },
  colors: [color],
  tooltip: { enabled: false }
})

const formatNum = (n) => (n || 0).toLocaleString('es-SV', { 
  minimumFractionDigits: 2,
  maximumFractionDigits: 2
});

const cargarDashboard = async () => {
  try {
    cargando.value = true
    const ahora = new Date();
    // Primer día del mes actual (ej: 2026-03-01)
    const desde = new Date(ahora.getFullYear(), ahora.getMonth(), 1).toISOString().split('T')[0];
    // Fecha de hoy (ej: 2026-03-30)
    const hasta = ahora.toISOString().split('T')[0];

    const res = await api.get('/api/kardex/dashboard-stats', {
      params: { desde, hasta }
    })

    // Mapear los datos que vienen del C# 
    stats.value = res.data
    console.log("Datos de gráfica:", res.data.datosGrafica)
    // Actualizar Gráfica
    if (res.data.datosGrafica && res.data.datosGrafica.length > 0) {
  
  //  array de series completo (no solo la propiedad interna)
  chartSeries.value = [{
    name: 'Ingresos',
    data: res.data.datosGrafica.map(i => i.totalDia)
  }];

  // chartOptions completo para que Vue dispare el cambio al componente
  chartOptions.value = {
    ...chartOptions.value,
    xaxis: {
      ...chartOptions.value.xaxis,
      categories: res.data.datosGrafica.map(i => formatFecha(i.fecha))
    }
  };
}
   } catch (e) {
    console.error("Error cargando Dashboard:", e)
  } finally {
    cargando.value = false
  }
}

onMounted(cargarDashboard)
</script>

<style scoped>
.dashboard-container {
  font-family: 'Inter', -apple-system, sans-serif;
}
</style>