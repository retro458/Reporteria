import { defineStore } from 'pinia'
import axios from 'axios'

export const useAuthStore = defineStore('auth', {
  state: () => ({
    token:    localStorage.getItem('token') || '',
    username: localStorage.getItem('username') || '',
    rol:      localStorage.getItem('rol') || '',
    empresa:  localStorage.getItem('empresa') || '',
    dbName:   localStorage.getItem('dbName') || '',
    isExpired: false, // Flag para controlar si el token expiró
  }),

  getters: {
    isAuthenticated: (state) => !!state.token && state.token.length > 20,
    
  },

  actions:
  {
    // 2. AGREGAMOS LA ACCIÓN QUE LLAMARÁ EL INTERCEPTOR
    setExpired(value: boolean) {
      this.isExpired = value
    },
    async login(tenant: string, username: string, password: string) {
      const API_URL = import.meta.env.VITE_API_URL || 'http://localhost:5169';
      const res = await axios.post(`${API_URL}/api/auth/login`, {
        tenant,
        username,
        password
      })

      // Guardar en state
      this.token    = res.data.token
      this.username = res.data.username
      this.rol      = res.data.rol
      this.empresa  = res.data.empresa
      this.dbName   = res.data.dbName

      // Guardar en localStorage para persistir al recargar
      localStorage.setItem('token',    res.data.token)
      localStorage.setItem('username', res.data.username)
      localStorage.setItem('rol',      res.data.rol)
      localStorage.setItem('empresa',  res.data.empresa)
      localStorage.setItem('dbName',   res.data.dbName)
    },

    logout() {
      this.token    = ''
      this.username = ''
      this.rol      = ''
      this.empresa  = ''
      this.dbName   = ''
      localStorage.clear()
    }
  }
})