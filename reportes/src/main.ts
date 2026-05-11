import { createApp } from 'vue'
import { createPinia } from 'pinia'
import App from './App.vue'
import router from './router'
import './assets/main.css'
import axios from 'axios'
import { useAuthStore } from './stores/auth'
import VueApexCharts from "vue3-apexcharts";
import Vue3Lottie from 'vue3-lottie'
//import { LottiePlayer } from '@lottiefiles/vue-lottie-player';
// Configuración global de Axios
axios.defaults.withCredentials = true;
const app = createApp(App)
const pinia = createPinia() // 1. Creamos la instancia

app.use(pinia) // 2. La instalamos PRIMERO
app.use(router)
app.use(VueApexCharts);
app.use(Vue3Lottie)
//app.component('lottie-player', LottiePlayer);

// Interceptor de respuesta
axios.interceptors.response.use(
  response => response,
  error => {
    // Si la API responde 401 (No autorizado/Expirado)
    if (error.response?.status === 401) {
      const authStore = useAuthStore(); 
      
      // Solo activamos el modal si no estamos ya en el login
      if (router.currentRoute.value.name !== 'login') {
        authStore.setExpired(true); 
      }
    }
    return Promise.reject(error);
  }
);

app.mount('#app')