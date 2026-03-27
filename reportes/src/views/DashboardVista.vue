<template>
    <div class="p-4">
      <div class="grid grid-cols-1 md:grid-cols-3 gap-4 mb-6">
        <div class="card bg-white p-4 shadow rounded-lg border-l-4 border-green-500">
          <h3 class="text-gray-500 text-sm font-bold">VENTAS DEL PERIODO</h3>
          <p class="text-2xl font-bold">${{ stats.valorVentasPeriodo }}</p>
        </div>
        <div class="card bg-white p-4 shadow rounded-lg border-l-4 border-blue-500">
          <h3 class="text-gray-500 text-sm font-bold">TOTAL PRODUCTOS</h3>
          <p class="text-2xl font-bold">{{ stats.totalProductos }}</p>
        </div>
        <div class="card bg-white p-4 shadow rounded-lg border-l-4 border-red-500">
          <h3 class="text-gray-500 text-sm font-bold">INVERSIÓN COMPRAS</h3>
          <p class="text-2xl font-bold">${{ stats.inversionComprasPeriodo }}</p>
        </div>
      </div>
  
      <div class="bg-white p-6 shadow rounded-lg">
        <h3 class="font-bold mb-4">Tendencia de Ventas (Últimos 7 días)</h3>
        <apexchart 
          type="area" 
          height="350" 
          :options="chartOptions" 
          :series="chartSeries"
        ></apexchart>
      </div>
    </div>
  </template>
  
  <script setup>
  import { ref, onMounted } from 'vue'
  import api from '@/api/config' //  instancia con el Interceptor
  
  const stats = ref({
    totalProductos: 0,
    valorVentasPeriodo: 0,
    inversionComprasPeriodo: 0
  })
  
  // Configuración de la Gráfica
  const chartSeries = ref([{
    name: 'Ventas ($)',
    data: [0, 0, 26.66, 13.33, 13.33, 0] // Aquí irán  datos del SP
  }])
  
  const chartOptions = ref({
    chart: { id: 'ventas-diarias', toolbar: { show: false } },
    colors: ['#10b981'], // Verde esmeralda (éxito)
    stroke: { curve: 'smooth' },
    xaxis: {
      categories: [],
      labels: { style: { colors: '#64748b' } }
    },
    yaxis: {
      labels: {
        formatter: (val) => `$${val.toFixed(2)}`
      }
    },
    dataLabels: { enabled: false },
    tooltip: {y: { formatter: (val) => `$${val.toFixed(2)}` }}
  })
  
  const formatFecha = (fechaRaw) => {
    const fecha = new Date(fechaRaw)
    return new Intl.DateTimeFormat('es-SV', { day: '2-digit', moth: 'short' }).format(fecha).replace('.', '');
  }
  
  const cargarDashboard = async () => {
  try {
    const hoy = new Date().toISOString().split('T')[0];
    const hace7Dias = new Date();
    hace7Dias.setDate(hace7Dias.getDate() - 7);
    const desde = hace7Dias.toISOString().split('T')[0];

    const res = await api.get('/api/kardex/dashboard-stats', {
      params: { desde, hasta: hoy }
    })


    stats.value = {
      totalProductos: res.data.totalProductos || 0,
      valorVentasPeriodo: res.data.ventas || 0,
      inversionComprasPeriodo: res.data.inversion || 0
    }

    if (res.data.graficaVentas && res.data.graficaVentas.length > 0) {
      chartSeries.value[0].data = res.data.graficaVentas.map(i => i.totalDia);
      
      chartOptions.value = {
        ...chartOptions.value,
        xaxis: {
          ...chartOptions.value.xaxis,
          
          categories: res.data.graficaVentas.map(i => formatFecha(i.fecha))
        }
      };
    }
  } catch (e) {
    console.error("Error en Dashboard", e)
  }
}

onMounted(() => {
  cargarDashboard();
})
  </script>