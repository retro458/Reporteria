<template>
  <header class="h-12 flex items-center justify-between px-8 relative z-50"
    style="background: rgba(251,251,253,0.9); backdrop-filter: blur(20px); border-bottom: 1px solid rgba(0,0,0,0.07);">

    <div class="flex items-center gap-2">
      <span class="text-[13px] font-medium text-gray-800">{{ currentRoute }}</span>
    </div>
<div class="flex items-center gap-3">
  <div class="flex items-center gap-1.5 text-[11px] text-gray-400">
    <div class="w-1.5 h-1.5 rounded-full bg-green-400"></div>
    En vivo
  </div>
  <div style="width:1px; height:14px; background:rgba(0,0,0,0.1)"></div>
  <span class="text-[11px] text-gray-400">{{ now }}</span>
  <div style="width:1px; height:14px; background:rgba(0,0,0,0.1)"></div>

  <!-- Usuario -->
  <div class="relative" ref="menuRef">
    <button @click="menuOpen = !menuOpen"
      class="flex items-center gap-2 px-2.5 py-1.5 rounded-lg hover:bg-black/5 transition-all duration-150">
      <div class="w-6 h-6 rounded-full bg-blue-500 flex items-center justify-center">
        <span class="text-white text-[10px] font-semibold">{{ initials }}</span>
      </div>
      <span class="text-[12px] text-gray-600 font-medium">{{ username }}</span>
      <svg class="w-3 h-3 text-gray-400" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2">
        <path d="M6 9l6 6 6-6"/>
      </svg>
    </button>

    <!-- Dropdown -->
    <div v-if="menuOpen"
      class="absolute right-0 top-full mt-1.5 w-44 rounded-xl py-1 z-50"
      style="background: rgba(255,255,255,0.95); backdrop-filter: blur(20px); border: 1px solid rgba(0,0,0,0.08); box-shadow: 0 8px 24px rgba(0,0,0,0.1)">
      <div class="px-3 py-2 border-b mb-1" style="border-color: rgba(0,0,0,0.06)">
        <div class="text-[12px] font-medium text-gray-700">{{ username }}</div>
        <div class="text-[11px] text-gray-400">{{ empresa }}</div>
      </div>
      <button @click="handleLogout"
        class="w-full text-left px-3 py-2 text-[12px] text-red-500 hover:bg-red-50 transition-colors flex items-center gap-2">
        <svg class="w-3.5 h-3.5" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2">
          <path d="M9 21H5a2 2 0 0 1-2-2V5a2 2 0 0 1 2-2h4"/>
          <polyline points="16 17 21 12 16 7"/>
          <line x1="21" y1="12" x2="9" y2="12"/>
        </svg>
        Cerrar sesión
      </button>
    </div>
  </div>
</div>

  </header>
  <div v-if="showLogoutModal" 
     class="fixed inset-0 z-[100] flex items-center justify-center bg-black/40 backdrop-blur-md p-4 transition-all">
  
  <div class="bg-white dark:bg-[#1c1c1e] rounded-3xl p-8 max-w-sm w-full shadow-[0_20px_50px_rgba(0,0,0,0.2)] border border-gray-100 dark:border-white/10 transform transition-all scale-100">
    
    <div class="text-center">
      <div class="mx-auto w-16 h-16 bg-red-50 dark:bg-red-500/10 rounded-full flex items-center justify-center mb-6">
        <i class="pi pi-power-off text-red-500 text-2xl" :class="{ 'animate-pulse': isLoggingOut }"></i>
      </div>
      
      <h3 class="text-2xl font-bold text-gray-900 dark:text-white mb-2">¿Cerrar sesión?</h3>
      <p class="text-gray-500 dark:text-gray-400 mb-8">
        ¿Estás seguro de que deseas salir? Tendrás que volver a ingresar tus credenciales.
      </p>
    </div>

    <div class="flex flex-col space-y-3">
      <button 
        @click="confirmLogout" 
        :disabled="isLoggingOut"
        class="w-full py-4 rounded-2xl bg-red-500 hover:bg-red-600 disabled:opacity-70 disabled:cursor-not-allowed text-white font-semibold shadow-lg shadow-red-500/25 transition-all flex items-center justify-center space-x-2"
      >
        <i v-if="isLoggingOut" class="pi pi-spin pi-spinner text-lg"></i>
        <span>{{ isLoggingOut ? 'Cerrando sesión...' : 'Cerrar Sesión' }}</span>
      </button>

      <button 
        @click="showLogoutModal = false" 
        :disabled="isLoggingOut"
        class="w-full py-4 rounded-2xl bg-gray-100 dark:bg-white/5 hover:bg-gray-200 dark:hover:bg-white/10 text-gray-700 dark:text-gray-300 font-semibold transition-all"
      >
        Cancelar
      </button>
    </div>
  </div>
</div>
</template>

<script setup lang="ts">
import { ref, computed, onMounted, onUnmounted } from 'vue'
import { useRoute, useRouter } from 'vue-router'
import { useAuthStore } from '@/stores/auth' // 1. Importamos el store

const route = useRoute()
const router = useRouter()
const auth = useAuthStore()
const now = ref('')
const menuOpen = ref(false)
const menuRef = ref<HTMLElement | null>(null)
const showLogoutModal = ref(false)
const isLoggingOut = ref(false)

const routeNames: Record<string, string> = {
  '/':           'Dashboard',
  '/ventas':     'Ventas',
  '/inventario': 'Inventario',
  '/compras':    'Compras',
  '/empleados':  'Empleados',

}

const currentRoute = computed(() => routeNames[route.path] || 'Reportería')

// Cuando este el API esto vendrá del store/token JWT
const username = computed(() => auth.username || 'Invitado')
const empresa  = computed(() => auth.empresa || 'CloudPocket')
const initials = computed(() => username.value.slice(0, 2).toUpperCase())

const handleLogout = () => {
  menuOpen.value = false // Cerramos el dropdown del perfil primero
  showLogoutModal.value = true
}
const confirmLogout = async () => {
  if (isLoggingOut.value) return // Evita múltiples clics
  
  isLoggingOut.value = true // Iniciamos la carga
  
  try {
    // Simulamos un pequeño delay de 500ms para que la transición no sea brusca
    await new Promise(resolve => setTimeout(resolve, 500))
    
    await auth.logout()
    showLogoutModal.value = false
    router.push('/login')
  } catch (error) {
    //console.error("Error al cerrar sesión:", error)
    //alert("Hubo un problema al conectar con el servidor, pero limpiaremos tu sesión local.")
    // En caso de error, igual limpiamos y redirigimos por seguridad
    router.push('/login')
  } finally {
    isLoggingOut.value = false
  }
}
// Cierra el dropdown si se clickea afuera
const handleClickOutside = (e: MouseEvent) => {
  if (menuRef.value && !menuRef.value.contains(e.target as Node)) {
    menuOpen.value = false
  }
}

onMounted(() => {
  const update = () => { now.value = new Date().toLocaleString('es-SV') }
  update()
  setInterval(update, 1000)
  document.addEventListener('click', handleClickOutside)
})

onUnmounted(() => {
  document.removeEventListener('click', handleClickOutside)
})
</script>