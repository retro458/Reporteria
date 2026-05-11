<template>
  <div class="h-screen w-full flex flex-col items-center justify-center bg-[#f5f5f7]">
    <div class="mb-8 animate-bounce">
       <div class="w-20 h-20 bg-blue-600 rounded-2xl flex items-center justify-center shadow-lg shadow-blue-200">
         <span class="text-white text-4xl font-bold">CP</span>
       </div>
    </div>

    <h1 class="text-2xl font-semibold text-gray-800 mb-2">Bienvenido a CloudPocket</h1>
    <p class="text-gray-500 mb-8 text-center max-w-xs">
      Gestiona tu inventario y kardex de forma eficiente y segura.
    </p>

    <div v-if="validando" class="flex flex-col items-center">
      <div class="animate-spin rounded-full h-8 w-8 border-b-2 border-blue-600"></div>
      <p class="mt-4 text-xs text-gray-400 uppercase tracking-widest">Verificando sesión</p>
    </div>

    <div v-else class="flex gap-4">
      <router-link to="/login" 
        class="px-8 py-3 bg-blue-600 text-white rounded-xl font-medium hover:bg-blue-700 transition-all shadow-md">
        Iniciar Sesión
      </router-link>
    </div>
  </div>
</template>

<script setup lang="ts">
import { ref, onMounted } from 'vue'
import { useRouter } from 'vue-router'
import { useAuthStore } from '@/stores/auth'

const router = useRouter()
const auth = useAuthStore()
const validando = ref(true)

onMounted(() => {
  // 1. Si ya sabemos que está autenticado, saltamos el delay
  if (auth.isAuthenticated) {
    router.push('/Kardex - General')
    return 
  }

  // 2. Si no, esperamos un poco para que la animación se luzca antes de mostrar el botón
  setTimeout(() => {
    validando.value = false

  }, 1000)
})
</script>