<template>
    <div class="min-h-screen" style="background: #fbfbfd; font-family: -apple-system, BlinkMacSystemFont, 'SF Pro Display', 'Segoe UI', sans-serif;">
  
      <!-- NAV -->
      <nav class="fixed top-0 left-0 right-0 z-50 flex items-center justify-between px-8 h-14"
        style="background: rgba(251,251,253,0.85); backdrop-filter: blur(20px); -webkit-backdrop-filter: blur(20px); border-bottom: 1px solid rgba(0,0,0,0.06);">
        <div class="flex items-center gap-2.5">
          <div class="w-7 h-7 rounded-lg bg-blue-500 flex items-center justify-center"
            style="box-shadow: 0 2px 8px rgba(59,130,246,0.3)">
            <span class="text-white text-xs font-bold">CP</span>
          </div>
          <span class="text-[14px] font-semibold text-gray-800">CloudPocket</span>
        </div>
        <div class="hidden md:flex items-center gap-8">
          <a v-for="item in navLinks" :key="item.label" :href="item.href"
            class="text-[13px] text-gray-500 hover:text-gray-800 transition-colors">{{ item.label }}</a>
        </div>
      </nav>
  
      <!-- HERO -->
      <section class="pt-36 pb-24 px-6 text-center relative overflow-hidden">
        <div class="absolute inset-0 pointer-events-none overflow-hidden">
          <div class="absolute top-0 left-1/2 -translate-x-1/2 w-[800px] h-[500px] opacity-30"
            style="background: radial-gradient(ellipse, rgba(59,130,246,0.15), transparent 70%); filter: blur(40px)"></div>
        </div>
        <div class="relative max-w-3xl mx-auto">
          <div class="inline-flex items-center gap-2 px-3 py-1 rounded-full text-[11px] font-medium text-blue-600 mb-6"
            style="background: rgba(59,130,246,0.08); border: 1px solid rgba(59,130,246,0.15)">
            <div class="w-1.5 h-1.5 rounded-full bg-blue-500"></div>
            Sistema de gestión empresarial
          </div>
          <h1 class="text-[52px] font-semibold text-gray-900 leading-tight tracking-tight mb-5">
            Controla tu negocio<br>
            <span style="background: linear-gradient(135deg, #3b82f6, #6366f1); -webkit-background-clip: text; -webkit-text-fill-color: transparent;">
              con claridad total
            </span>
          </h1>
          <p class="text-[17px] text-gray-500 leading-relaxed mb-10 max-w-xl mx-auto">
            Reportería en tiempo real, control de inventario y facturación electrónica en una sola plataforma. Diseñada para empresas salvadoreñas.
          </p>
          <div class="flex items-center justify-center gap-3 flex-wrap">
            <RouterLink to="/login"
              class="px-6 py-3 rounded-xl text-[14px] font-medium text-white transition-all"
              style="background: #3b82f6; box-shadow: 0 4px 16px rgba(59,130,246,0.35)">
              Comenzar ahora
            </RouterLink>
            <a href="#features"
              class="px-6 py-3 rounded-xl text-[14px] font-medium text-gray-600 transition-all hover:bg-black/5"
              style="border: 1px solid rgba(0,0,0,0.1)">
              Ver funciones
            </a>
          </div>
        </div>
      </section>
  
      <!-- STATS -->
      <section class="py-12 px-6">
        <div class="max-w-4xl mx-auto grid grid-cols-2 md:grid-cols-4 gap-4">
          <div v-for="stat in stats" :key="stat.label"
            class="text-center p-5 rounded-2xl"
            style="background: white; border: 1px solid rgba(0,0,0,0.06); box-shadow: 0 1px 4px rgba(0,0,0,0.04)">
            <div class="text-[28px] font-semibold text-gray-900 tracking-tight">{{ stat.value }}</div>
            <div class="text-[12px] text-gray-400 mt-1">{{ stat.label }}</div>
          </div>
        </div>
      </section>
  
      <!-- FEATURES -->
      <section id="features" class="py-20 px-6">
        <div class="max-w-5xl mx-auto">
          <div class="text-center mb-14">
            <h2 class="text-[34px] font-semibold text-gray-900 tracking-tight mb-3">Todo lo que necesitas</h2>
            <p class="text-[15px] text-gray-400 max-w-md mx-auto">Una plataforma completa para gestionar cada aspecto de tu empresa.</p>
          </div>
          <div class="grid md:grid-cols-3 gap-4">
            <div v-for="feature in features" :key="feature.title"
              class="p-6 rounded-2xl transition-all duration-200 hover:-translate-y-0.5"
              style="background: white; border: 1px solid rgba(0,0,0,0.06); box-shadow: 0 1px 4px rgba(0,0,0,0.04)">
              <div class="w-10 h-10 rounded-xl flex items-center justify-center mb-4"
                :style="`background: ${feature.color}15`">
                <span class="text-xl">{{ feature.icon }}</span>
              </div>
              <h3 class="text-[15px] font-semibold text-gray-800 mb-2">{{ feature.title }}</h3>
              <p class="text-[13px] text-gray-400 leading-relaxed">{{ feature.desc }}</p>
            </div>
          </div>
        </div>
      </section>
  
      <!-- HOW IT WORKS -->
      <section class="py-20 px-6" style="background: white;">
        <div class="max-w-4xl mx-auto">
          <div class="text-center mb-14">
            <h2 class="text-[34px] font-semibold text-gray-900 tracking-tight mb-3">Simple de usar</h2>
            <p class="text-[15px] text-gray-400">En tres pasos estás operando.</p>
          </div>
          <div class="grid md:grid-cols-3 gap-8">
            <div v-for="(step, i) in steps" :key="i" class="text-center">
              <div class="w-10 h-10 rounded-full flex items-center justify-center mx-auto mb-4 text-[14px] font-semibold text-white"
                style="background: #3b82f6">{{ i + 1 }}</div>
              <h3 class="text-[15px] font-semibold text-gray-800 mb-2">{{ step.title }}</h3>
              <p class="text-[13px] text-gray-400 leading-relaxed">{{ step.desc }}</p>
            </div>
          </div>
        </div>
      </section>
  
      <!-- PRICING -->
      <section id="pricing" class="py-20 px-6">
        <div class="max-w-4xl mx-auto">
          <div class="text-center mb-14">
            <h2 class="text-[34px] font-semibold text-gray-900 tracking-tight mb-3">Planes claros</h2>
            <p class="text-[15px] text-gray-400">Sin sorpresas. Paga solo por lo que usas.</p>
          </div>
          <div class="grid md:grid-cols-3 gap-4">
            <div v-for="plan in plans" :key="plan.name"
              class="p-6 rounded-2xl transition-all duration-200"
              :style="plan.featured
                ? 'background: #3b82f6; border: 1px solid #3b82f6; box-shadow: 0 8px 32px rgba(59,130,246,0.25)'
                : 'background: white; border: 1px solid rgba(0,0,0,0.06); box-shadow: 0 1px 4px rgba(0,0,0,0.04)'">
              <div class="text-[12px] font-medium mb-3" :class="plan.featured ? 'text-blue-200' : 'text-gray-400'">
                {{ plan.name }}
              </div>
              <div class="text-[32px] font-semibold tracking-tight mb-1" :class="plan.featured ? 'text-white' : 'text-gray-900'">
                {{ plan.price }}
                <span class="text-[14px] font-normal" :class="plan.featured ? 'text-blue-200' : 'text-gray-400'">/mes</span>
              </div>
              <p class="text-[12px] mb-5" :class="plan.featured ? 'text-blue-100' : 'text-gray-400'">{{ plan.desc }}</p>
              <div style="height:1px; margin-bottom:1.25rem" :style="plan.featured ? 'background:rgba(255,255,255,0.15)' : 'background:rgba(0,0,0,0.06)'"></div>
              <ul class="space-y-2.5 mb-6">
                <li v-for="f in plan.features" :key="f" class="flex items-center gap-2 text-[12px]"
                  :class="plan.featured ? 'text-blue-50' : 'text-gray-500'">
                  <svg class="w-3.5 h-3.5 flex-shrink-0" :class="plan.featured ? 'text-blue-200' : 'text-blue-400'"
                    viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2.5">
                    <path d="M20 6L9 17l-5-5"/>
                  </svg>
                  {{ f }}
                </li>
              </ul>
              <RouterLink to="/login"
                class="block text-center py-2.5 rounded-xl text-[13px] font-medium transition-all"
                :style="plan.featured
                  ? 'background: white; color: #3b82f6'
                  : 'background: rgba(59,130,246,0.08); color: #3b82f6; border: 1px solid rgba(59,130,246,0.15)'">
                Comenzar
              </RouterLink>
            </div>
          </div>
        </div>
      </section>
  
      <!-- CTA -->
      <section class="py-20 px-6" style="background: white;">
        <div class="max-w-2xl mx-auto text-center">
          <h2 class="text-[34px] font-semibold text-gray-900 tracking-tight mb-4">
            ¿Listo para empezar?
          </h2>
          <p class="text-[15px] text-gray-400 mb-8">Agenda una demo y te mostramos el sistema funcionando con tus datos.</p>
          <a href="mailto:contacto@cloudpocket.online"
            class="inline-flex items-center gap-2 px-6 py-3 rounded-xl text-[14px] font-medium text-white transition-all"
            style="background: #3b82f6; box-shadow: 0 4px 16px rgba(59,130,246,0.35)">
            Contactar ahora
            <svg class="w-4 h-4" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2">
              <path d="M5 12h14M12 5l7 7-7 7"/>
            </svg>
          </a>
        </div>
      </section>
  
      <!-- FOOTER -->
      <footer class="py-8 px-6 border-t" style="border-color: rgba(0,0,0,0.06)">
        <div class="max-w-5xl mx-auto flex flex-col md:flex-row items-center justify-between gap-4">
          <div class="flex items-center gap-2">
            <div class="w-5 h-5 rounded-md bg-blue-500 flex items-center justify-center">
              <span class="text-white text-[8px] font-bold">CP</span>
            </div>
            <span class="text-[12px] text-gray-400">CloudPocket © {{ new Date().getFullYear() }}</span>
          </div>
          <div class="flex items-center gap-6">
            <a v-for="link in footerLinks" :key="link" href="#"
              class="text-[12px] text-gray-400 hover:text-gray-600 transition-colors">{{ link }}</a>
          </div>
        </div>
      </footer>
  
    </div>
  </template>
  
  <script setup lang="ts">
  const navLinks = [
    { label: 'Funciones', href: '#features' },
    { label: 'Precios',   href: '#pricing'  },
    { label: 'Contacto',  href: '#contacto' },
  ]
  
  const stats = [
    { value: '100%', label: 'DTE compatible' },
    { value: '<1s',  label: 'Tiempo de respuesta' },
    { value: '24/7', label: 'Disponibilidad' },
    { value: '∞',    label: 'Empresas conectadas' },
  ]
  
  const features = [
    { icon: '📊', color: '#3b82f6', title: 'Reportería en tiempo real',   desc: 'Ventas, inventario y compras actualizados al instante. Exporta a Excel o PDF con un clic.' },
    { icon: '📦', color: '#10b981', title: 'Control de inventario',        desc: 'Kardex completo, alertas de stock mínimo y trazabilidad de movimientos por almacén.' },
    { icon: '🧾', color: '#6366f1', title: 'Facturación electrónica DTE',  desc: 'Integrado con el Ministerio de Hacienda de El Salvador. CCF, Factura, Nota de Crédito y más.' },
    { icon: '👥', color: '#f59e0b', title: 'Multi-empresa',                desc: 'Cada empresa tiene sus propios datos aislados. Un solo login, múltiples empresas.' },
    { icon: '🔒', color: '#ef4444', title: 'Roles y permisos',             desc: 'Define qué puede ver y hacer cada usuario dentro del sistema.' },
    { icon: '📱', color: '#8b5cf6', title: 'Acceso desde cualquier lugar', desc: 'Funciona en cualquier dispositivo con un navegador. Sin instalaciones.' },
  ]
  
  const steps = [
    { title: 'Configura tu empresa',  desc: 'Registra tu empresa, usuarios y almacenes en minutos.' },
    { title: 'Conecta tus datos',     desc: 'Importamos tu catálogo de productos y clientes existente.' },
    { title: 'Opera desde el día uno',desc: 'Empieza a facturar, controlar stock y ver reportes de inmediato.' },
  ]
  
  const plans = [
    {
      name: 'Básico', price: '$29', featured: false,
      desc: 'Ideal para negocios pequeños',
      features: ['1 empresa', '3 usuarios', 'Reportes de ventas', 'Inventario básico', 'Soporte por email']
    },
    {
      name: 'Profesional', price: '$79', featured: true,
      desc: 'El más popular para PYMES',
      features: ['3 empresas', '10 usuarios', 'Reportes avanzados', 'DTE incluido', 'Multi-almacén', 'Soporte prioritario']
    },
    {
      name: 'Empresarial', price: '$149', featured: false,
      desc: 'Para operaciones más grandes',
      features: ['Empresas ilimitadas', 'Usuarios ilimitados', 'Todo incluido', 'API access', 'Soporte dedicado']
    },
  ]
  
  const footerLinks = ['Privacidad', 'Términos', 'Soporte']
  </script>