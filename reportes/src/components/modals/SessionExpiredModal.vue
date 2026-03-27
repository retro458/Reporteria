<template>
    <div v-if="isVisible" class="fixed inset-0 z-[100] flex items-center justify-center p-4">
      <div class="absolute inset-0 bg-black/20 backdrop-blur-md"></div>
  
      <div class="relative bg-white rounded-2xl p-8 max-w-sm w-full shadow-2xl border border-black/5 text-center">
        <div class="w-16 h-16 bg-amber-50 rounded-2xl flex items-center justify-center mx-auto mb-6">
          <svg class="w-8 h-8 text-amber-500" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="1.5">
            <circle cx="12" cy="12" r="10"/>
            <polyline points="12 6 12 12 16 14"/>
          </svg>
        </div>
  
        <h2 class="text-xl font-bold text-gray-900 mb-2">Sesión expirada</h2>
        <p class="text-sm text-gray-500 mb-8 leading-relaxed">
          Tu sesión ha caducado por seguridad.<br>Por favor, ingresa de nuevo.
        </p>
  
        <button @click="relogin" class="w-full py-3 bg-black text-white rounded-xl font-semibold hover:bg-blue-600 transition-colors flex items-center justify-center gap-2">
          <span>Iniciar sesión</span>
        </button>
      </div>
    </div>
  </template>
  
  <script setup lang="ts">
  import { ref } from 'vue'
  import { useRouter } from 'vue-router'
  import { useAuthStore } from '@/stores/auth'
  
  const isVisible = ref(false)
  const router = useRouter()
  const authStore = useAuthStore()
  
  // Función que llamaremos desde afuera
  const show = () => { isVisible.value = true }
  
  const relogin = () => {
    isVisible.value = false
    authStore.logout() // Limpia el store y localStorage
    router.push('/login')
  }
  
  // Exponemos la función show
  defineExpose({ show })
  </script>