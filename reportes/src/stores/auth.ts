import { defineStore } from 'pinia'
import axios from 'axios'

export const useAuthStore = defineStore('auth', {
  state: () => ({
    token:    localStorage.getItem('token') || '',
    username: localStorage.getItem('username') || '',
    rol:      localStorage.getItem('rol') || '',
    empresa:  localStorage.getItem('empresa') || '',
    dbName:   localStorage.getItem('dbName') || '',
    isExpired: false, // Este controlará la visibilidad del Modal
  }),

    getters: {
    isAuthenticated: (state) => !!state.username && state.username.length > 0,
  },

  actions: {
    // Esta acción la llama el interceptor en main.ts
    setExpired(value: boolean) {
      this.isExpired = value;
      if (value) {
        // Si expiró, limpiamos los datos para que no intente usarlos
        this.logout(); 
        this.isExpired = true; // Lo mantenemos en true para que el modal no se cierre solo
      }
    },

    async login(tenant: string, username: string, password: string) {
      // Importante: con HttpOnly, axios necesita enviar credenciales
      axios.defaults.withCredentials = true; 
      
      const API_URL = import.meta.env.VITE_API_URL || 'http://localhost:5169';
      const res = await axios.post(`${API_URL}/api/auth/login`, {
        tenant,
        username,
        password
      });

      // Nota: Al pasar a HttpOnly, res.data.token vendrá vacío 
      // porque el token estará en la Cookie inyectada por C#
      this.username = res.data.username;
      this.rol      = res.data.rol;
      this.isExpired = false; // Resetear al loguearse con éxito

      localStorage.setItem('username', res.data.username);
      localStorage.setItem('rol',      res.data.rol);
    },

    async logout() {
      try {
        const API_URL = import.meta.env.VITE_API_URL || 'http://localhost:5169';
        
        // 1. Avisamos al servidor (esto borra la cookie HttpOnly)
        await axios.post(`${API_URL}/api/auth/logout`, {}, { withCredentials: true });
      } catch (e) {
        console.error("No se pudo cerrar sesión en el servidor, pero limpiamos localmente.");
      } finally {
        // 2. Limpiamos el estado de Pinia
        this.username = '';
        this.rol      = '';
        this.empresa  = '';
        this.dbName   = '';
        
        // 3. Limpiamos LocalStorage
        localStorage.clear();
      }
    },
  }
})