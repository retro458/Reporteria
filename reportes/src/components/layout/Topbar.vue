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
  auth.logout() // 3. Usamos la acción del store (que ya limpia todo)
  router.push('/login')
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