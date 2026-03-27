<template>
  <div class="min-h-screen" style="background: #f5f5f7;">

    <RouterView v-if="isPublicRoute" />

    <div v-else-if="isAuthenticated" class="flex min-h-screen">
      <Sidebar />
      <div class="flex-1 flex flex-col ml-[240px]">
        <Topbar />
        <main class="flex-1 p-6">
          <RouterView />
        </main>
      </div>
      
    </div>

    <div v-else class="h-screen w-full flex flex-col items-center justify-center bg-white">
      <div class="animate-spin rounded-full h-10 w-10 border-b-2 border-blue-600"></div>
      <p class="mt-4 text-sm text-gray-500 font-medium">Validando acceso...</p>
    </div>
    
    <SessionExpiredModal ref="expiredModal" />
  </div>
</template>

<script setup lang="ts">
import { computed, ref, onMounted, provide } from 'vue'
import { useRoute } from 'vue-router'
import { useAuthStore } from '@/stores/auth' // Importamos el store
import { storeToRefs } from 'pinia'
import Sidebar from '@/components/layout/Sidebar.vue'
import Topbar from '@/components/layout/Topbar.vue'
import type { ComponentPublicInstance } from 'vue'
import SessionExpiredModal from '@/components/modals/SessionExpiredModal.vue'
const expiredModal = ref<InstanceType<typeof SessionExpiredModal> | null>(null)
const route = useRoute()
const auth = useAuthStore() // Instanciamos el store
const { isAuthenticated } = storeToRefs(useAuthStore()) // Extraemos la propiedad reactiva
const isPublicRoute = computed(() => {
  // Si la ruta no existe o es pública, la tratamos como tal para que no bloquee el login
  return route.meta.public === true 
})
provide('showSessionExpired', () => {
  if (expiredModal.value) {
    expiredModal.value.show() // Llamamos al método show del modal para mostrarlo
  }
})
</script>