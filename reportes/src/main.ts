import { createApp } from 'vue'
import { createPinia } from 'pinia'
import App from './App.vue'
import router from './router'
import './assets/main.css'
import axios from 'axios'

const app = createApp(App)
app.use(createPinia())
app.use(router)

axios.interceptors.response.use(
  response => response,
  error => {
    if (error.response?.status === 401) {
      const currentRoute = router.currentRoute.value.name
      if (currentRoute !== 'login' && currentRoute !== 'session-expired') {
        localStorage.removeItem('token')
        localStorage.removeItem('user')
        router.push({ name: 'session-expired' })
      }
    }
    return Promise.reject(error)
  }
)

app.mount('#app')