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
    
    <SessionExpiredModal v-if="isExpired" />
  </div>
</template>

<script setup lang="ts">
import { computed, ref } from 'vue'
import { useRoute } from 'vue-router'
import { useAuthStore } from '@/stores/auth' 
import { storeToRefs } from 'pinia'
import Sidebar from '@/components/layout/Sidebar.vue'
import Topbar from '@/components/layout/Topbar.vue'
import SessionExpiredModal from '@/components/modals/SessionExpiredModal.vue'

const route = useRoute()
const authStore = useAuthStore()

// Extraemos las propiedades reactivas del state y los getters
const { isExpired, isAuthenticated } = storeToRefs(authStore)

const isPublicRoute = computed(() => {
  return route.meta.public === true 
})
</script>