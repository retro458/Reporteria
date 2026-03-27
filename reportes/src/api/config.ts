import axios from 'axios'
import { useAuthStore } from '../stores/auth'
import router from '@/router'

const api = axios.create({
  // Vite inyectará la URL de https://api.cloudpocket.online en el build:app
  baseURL: import.meta.env.VITE_API_URL || 'http://localhost:5169'
})

// Interceptor para agregar el token a cada petición
api.interceptors.request.use(config => {
  const auth = useAuthStore()
  if (auth.token) {
    config.headers.Authorization = `Bearer ${auth.token}`
  }
  return config
},
error => Promise.reject(error))

api.interceptors.response.use(
  (response) => response, // Si todo sale bien, solo pasa la respuesta
  (error) => {
    // Si el servidor responde 401 es que el JWT expiró o es inválido
    if (error.response && error.response.status === 401) {
      const auth = useAuthStore()
      
      // Opción A: Activar un flag en el store para que App.vue muestre el modal
      auth.setExpired(true)
    }
    return Promise.reject(error)
  }
)

export default api