import { createRouter, createWebHistory } from 'vue-router'
import { useAuthStore } from '@/stores/auth'

const isLanding = import.meta.env.VITE_APP_MODE === 'landing'

const routes = isLanding
  ? [
      { path: '/', component: () => import('@/views/PaginaServicios.vue'), meta: { public: true } },
      { path: '/:pathMatch(.*)*', redirect: '/' }
    ]
  : [
      { 
        path: '/', 
        name: 'welcome', 
        component: () => import('@/views/WelcomeView.vue'), 
        meta: { public: true } 
      },
      { 
        path: '/login', 
        name: 'login', 
        component: () => import('@/views/LoginView.vue'), 
        meta: { public: true } 
      },
      // Rutas Protegidas
      { path: '/Kardex - Por Producto', component: () => import('@/views/KardexView.vue'), meta: { requiresAuth: true } },
      { path: '/Existencias', component: () => import('@/views/ExistenciasView.vue'), meta: { requiresAuth: true } },
      { path: '/Kardex - General', component: () => import('@/views/KardexGeneral.vue'), meta: { requiresAuth: true } },
      { path: '/dashboard', component: () => import('@/views/DashboardVista.vue'), meta: { requiresAuth: true } },
      {path: '/Producto-Stock', component: () => import('@/views/ProductoView.vue'), meta: { requiresAuth: true }},
      
      { path: '/:pathMatch(.*)*', redirect: '/' }
    ]

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes
})

// Guard — va después del createRouter
router.beforeEach((to, from, next) => {
  const auth = useAuthStore() // Usamos el Store, no el localStorage directamente

  // 1. Si la ruta requiere auth y el usuario NO está autenticado
  if (to.meta.requiresAuth && !auth.isAuthenticated) {
    next({ name: 'login' })
  } 
  // 2. Si intenta ir al login estando ya logueado
  else if (to.name === 'login' && auth.isAuthenticated) {
    next({ name: 'welcome' })
  } 
  // 3. En cualquier otro caso, dejar pasar
  else {
    next()
  }
})

export default router