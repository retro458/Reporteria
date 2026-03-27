import { createRouter, createWebHistory } from 'vue-router'

const isLanding = import.meta.env.VITE_APP_MODE === 'landing'
console.log('MODE:', import.meta.env.VITE_APP_MODE)
console.log('isLanding:', isLanding)


const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: isLanding
    ? [
        { path: '/', component: () => import('@/views/PaginaServicios.vue'), meta: { public: true } },
        { path: '/:pathMatch(.*)*', redirect: '/' }
      ]
    : [
      { 
        path: '/', 
        name: 'welcome', 
        component: () => import('@/views/WelcomeView.vue'), 
        meta: { public: true } // La hacemos pública para que App.vue la muestre
      },
        { path: '/login', name: 'login', component: () => import('@/views/LoginView.vue'), meta: { public: true } },
        { path: '/Kardex - Por Producto', component: () => import('@/views/KardexView.vue'), meta: { requiresAuth: true } },
        { path: '/Existencias', component: () => import('@/views/ExistenciasView.vue'), meta: { requiresAuth: true } },
        { path: '/Kardex - General', component: () => import('@/views/KardexGeneral.vue'), meta: { requiresAuth: true } },
        {path : '/dashboard', component: () => import('@/views/DashboardVista.vue'), meta: { requiresAuth: true }},

        {
          path: '/session-expired',
          name: 'session-expired',
          component: () => import('@/views/SesionExpiradaView.vue'),
          meta: { requiresAuth: false }
        },
      ]
})

// Guard — va después del createRouter
router.beforeEach((to, from, next) => {
  const token = localStorage.getItem('token')

  if (to.meta.requiresAuth && !token) {
    next('/login')        // Sin token → manda al login
  } else if (to.path === '/login' && token) {
    next('/')             // Ya logueado → no deja volver al login
  } else {
    next()                // Todo bien → continúa
  }
})

export default router