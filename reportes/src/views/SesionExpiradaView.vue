<template>
    <div class="expired-root">
      <div class="expired-card">
  
        <!-- Icono -->
        <div class="icon-wrap">
          <svg viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="1.5">
            <circle cx="12" cy="12" r="10"/>
            <polyline points="12 6 12 12 16 14"/>
          </svg>
        </div>
  
        <!-- Texto -->
        <h1 class="title">Sesión expirada</h1>
        <p class="subtitle">
          Tu sesión ha caducado por inactividad.<br>
          Por favor inicia sesión nuevamente para continuar.
        </p>
  
        <!-- Botón -->
        <button class="btn-login" @click="irALogin">
          <svg viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2">
            <path d="M15 3h4a2 2 0 0 1 2 2v14a2 2 0 0 1-2 2h-4"/>
            <polyline points="10 17 15 12 10 7"/>
            <line x1="15" y1="12" x2="3" y2="12"/>
          </svg>
          Iniciar sesión
        </button>
  
      </div>
    </div>
  </template>
  
  <script setup lang="ts">
  import { useRouter } from 'vue-router'
  
  const router = useRouter()
  
  const irALogin = () => {
    router.push({ name: 'login' })
  }
  </script>
  
  <style scoped>
  .expired-root {
    min-height: 100vh;
    background: #f5f5f7;
    display: flex;
    align-items: center;
    justify-content: center;
    font-family: 'SF Pro Display', -apple-system, sans-serif;
    padding: 24px;
  }
  
  .expired-card {
    background: white;
    border-radius: 20px;
    padding: 48px 40px;
    max-width: 400px;
    width: 100%;
    text-align: center;
    box-shadow: 0 2px 12px rgba(0,0,0,0.06);
    border: 1px solid rgba(0,0,0,0.06);
  }
  
  .icon-wrap {
    width: 64px;
    height: 64px;
    background: #fff8e1;
    border-radius: 18px;
    display: flex;
    align-items: center;
    justify-content: center;
    margin: 0 auto 24px;
  }
  
  .icon-wrap svg {
    width: 30px;
    height: 30px;
    stroke: #f57f17;
  }
  
  .title {
    font-size: 22px;
    font-weight: 700;
    color: #1d1d1f;
    margin: 0 0 10px;
  }
  
  .subtitle {
    font-size: 14px;
    color: #86868b;
    line-height: 1.6;
    margin: 0 0 32px;
  }
  
  .btn-login {
    display: inline-flex;
    align-items: center;
    gap: 8px;
    padding: 12px 28px;
    background: #1d1d1f;
    color: white;
    border: none;
    border-radius: 12px;
    font-size: 14px;
    font-weight: 600;
    cursor: pointer;
    transition: background 0.15s;
  }
  
  .btn-login:hover {
    background: #0071e3;
  }
  
  .btn-login svg {
    width: 16px;
    height: 16px;
  }
  </style>