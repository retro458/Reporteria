<template>
    <div class="min-h-screen flex items-center justify-center" style="background: #f5f5f7;">
  
      <!-- Background blur circles -->
      <div class="fixed inset-0 overflow-hidden pointer-events-none">
        <div class="absolute -top-40 -right-40 w-96 h-96 rounded-full opacity-20"
          style="background: radial-gradient(circle, #3b82f6, transparent); filter: blur(60px)"></div>
        <div class="absolute -bottom-40 -left-40 w-96 h-96 rounded-full opacity-10"
          style="background: radial-gradient(circle, #6366f1, transparent); filter: blur(60px)"></div>
      </div>
  
      <!-- Card -->
      <div class="w-full max-w-sm mx-4 relative">
  
        <!-- Logo -->
        <div class="flex flex-col items-center mb-8">
          <div class="w-12 h-12 rounded-2xl bg-blue-500 flex items-center justify-center shadow-lg mb-4"
            style="box-shadow: 0 8px 24px rgba(59,130,246,0.35)">
            <span class="text-white text-lg font-bold">CP</span>
          </div>
          <h1 class="text-[22px] font-semibold text-gray-800 tracking-tight">Iniciar sesión</h1>
          <p class="text-[13px] text-gray-400 mt-1">CloudPocket Reportería</p>
        </div>
  
        <!-- Form card -->
        <div class="rounded-2xl p-6 shadow-sm"
          style="background: rgba(255,255,255,0.8); backdrop-filter: blur(20px); border: 1px solid rgba(0,0,0,0.08);">
  
          <!-- Empresa -->
          <div class="mb-4">
            <label class="block text-[12px] font-medium text-gray-600 mb-1.5">Empresa</label>
            <div class="relative">
              <select v-model="form.empresa"
                class="w-full px-3 py-2.5 rounded-xl text-[13px] text-gray-700 appearance-none outline-none transition-all duration-150"
                style="background: rgba(0,0,0,0.04); border: 1px solid rgba(0,0,0,0.08);"
                :style="focusedField === 'empresa' ? 'border-color: #3b82f6; box-shadow: 0 0 0 3px rgba(59,130,246,0.12)' : ''"
                @focus="focusedField = 'empresa'"
                @blur="focusedField = ''">
                <option value="" disabled>Selecciona una empresa</option>
                <option v-for="e in empresas" :key="e.value" :value="e.value">{{ e.label }}</option>
              </select>
              <div class="absolute right-3 top-1/2 -translate-y-1/2 pointer-events-none text-gray-400">
                <svg class="w-3.5 h-3.5" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2">
                  <path d="M6 9l6 6 6-6"/>
                </svg>
              </div>
            </div>
          </div>
  
          <!-- Usuario -->
          <div class="mb-4">
            <label class="block text-[12px] font-medium text-gray-600 mb-1.5">Usuario</label>
            <input
              v-model="form.usuario"
              type="text"
              placeholder="nombre de usuario"
              class="w-full px-3 py-2.5 rounded-xl text-[13px] text-gray-700 outline-none transition-all duration-150"
              style="background: rgba(0,0,0,0.04); border: 1px solid rgba(0,0,0,0.08);"
              :style="focusedField === 'usuario' ? 'border-color: #3b82f6; box-shadow: 0 0 0 3px rgba(59,130,246,0.12)' : ''"
              @focus="focusedField = 'usuario'"
              @blur="focusedField = ''"
              @keyup.enter="handleLogin"
            />
          </div>
  
          <!-- Contraseña -->
          <div class="mb-5">
            <label class="block text-[12px] font-medium text-gray-600 mb-1.5">Contraseña</label>
            <div class="relative">
              <input
                v-model="form.password"
                :type="showPassword ? 'text' : 'password'"
                placeholder="••••••••"
                class="w-full px-3 py-2.5 pr-10 rounded-xl text-[13px] text-gray-700 outline-none transition-all duration-150"
                style="background: rgba(0,0,0,0.04); border: 1px solid rgba(0,0,0,0.08);"
                :style="focusedField === 'password' ? 'border-color: #3b82f6; box-shadow: 0 0 0 3px rgba(59,130,246,0.12)' : ''"
                @focus="focusedField = 'password'"
                @blur="focusedField = ''"
                @keyup.enter="handleLogin"
              />
              <button type="button"
                class="absolute right-3 top-1/2 -translate-y-1/2 text-gray-400 hover:text-gray-600 transition-colors"
                @click="showPassword = !showPassword">
                <svg v-if="!showPassword" class="w-4 h-4" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="1.75">
                  <path d="M1 12s4-8 11-8 11 8 11 8-4 8-11 8-11-8-11-8z"/><circle cx="12" cy="12" r="3"/>
                </svg>
                <svg v-else class="w-4 h-4" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="1.75">
                  <path d="M17.94 17.94A10.07 10.07 0 0 1 12 20c-7 0-11-8-11-8a18.45 18.45 0 0 1 5.06-5.94M9.9 4.24A9.12 9.12 0 0 1 12 4c7 0 11 8 11 8a18.5 18.5 0 0 1-2.16 3.19m-6.72-1.07a3 3 0 1 1-4.24-4.24"/>
                  <line x1="1" y1="1" x2="23" y2="23"/>
                </svg>
              </button>
            </div>
          </div>
  
          <!-- Error -->
          <div v-if="error" class="mb-4 px-3 py-2.5 rounded-xl text-[12px] text-red-600"
            style="background: rgba(239,68,68,0.08); border: 1px solid rgba(239,68,68,0.15)">
            {{ error }}
          </div>
  
          <!-- Submit -->
          <button
            @click="handleLogin"
            :disabled="loading"
            class="w-full py-2.5 rounded-xl text-[13px] font-medium text-white transition-all duration-150 relative overflow-hidden"
            style="background: #3b82f6;"
            :style="loading ? 'opacity: 0.7' : 'box-shadow: 0 4px 12px rgba(59,130,246,0.35)'">
            <span v-if="!loading">Ingresar</span>
            <span v-else class="flex items-center justify-center gap-2">
              <svg class="animate-spin w-3.5 h-3.5" viewBox="0 0 24 24" fill="none">
                <circle cx="12" cy="12" r="10" stroke="currentColor" stroke-width="3" stroke-dasharray="32" stroke-dashoffset="12" opacity="0.3"/>
                <path d="M12 2a10 10 0 0 1 10 10" stroke="currentColor" stroke-width="3" stroke-linecap="round"/>
              </svg>
              Verificando...
            </span>
          </button>
  
        </div>
  
        <!-- Footer -->
        <p class="text-center text-[11px] text-gray-400 mt-6">
          CloudPocket © {{ new Date().getFullYear() }}
        </p>
  
      </div>
    </div>
  </template>
  
  <script setup lang="ts">
import { ref } from 'vue'
import { useRouter } from 'vue-router'
import { useAuthStore } from '@/stores/auth'

const router    = useRouter()
const authStore = useAuthStore()

const form = ref({ empresa: '', usuario: '', password: '' })
const focusedField = ref('')
const showPassword = ref(false)
const loading = ref(false)
const error = ref('')

// Por ahora fijo — cuando tenga múltiples subdominios 
// esto vendrá del API
const empresas = ref([
  { value: 'clutch', label: 'Clutch Express' },
])

const handleLogin = async () => {
  error.value = ''

  if (!form.value.empresa || !form.value.usuario || !form.value.password) {
    error.value = 'Completa todos los campos para continuar.'
    return
  }

  loading.value = true

  try {
    await authStore.login(
      form.value.empresa,   // tenant: 'clutch'
      form.value.usuario,
      form.value.password
    )
    router.push('/')

  } catch (e: any) {
    // El API devuelve 401 con { message: '...' }
    error.value = e.response?.data?.message || 'Error al conectar con el servidor.'
  }

  loading.value = false
}
</script>