<template>
  <aside class="fixed left-0 top-0 bottom-0 w-[240px] flex flex-col z-50"
    style="background: rgba(246,246,248,0.85); backdrop-filter: blur(20px); -webkit-backdrop-filter: blur(20px); border-right: 1px solid rgba(0,0,0,0.08);">

    <!-- Logo -->
    <div class="px-6 pt-6 pb-5">
  <div class="flex items-center gap-2.5">
    <img 
      src="@/assets/logo-clutch.png" 
      alt="Clutch Express" 
      class="h-8 w-auto object-contain"
    />
  </div>
</div>

    <!-- Divider -->
    <div class="mx-4 mb-3" style="height:1px; background: rgba(0,0,0,0.06)"></div>

    <!-- Nav -->
    <nav class="flex flex-col gap-0.5 px-2 flex-1">
      <RouterLink
        v-for="item in navItems"
        :key="item.to"
        :to="item.to"
        class="flex items-center gap-3 px-3 py-2 rounded-lg text-[13px] text-gray-500 transition-all duration-150 hover:bg-black/5 hover:text-gray-800"
        active-class="!bg-blue-500 !text-white shadow-sm"
      >
        <component :is="item.icon" class="w-4 h-4 flex-shrink-0" />
        {{ item.label }}
      </RouterLink>
    </nav>

  

  </aside>
</template>

<script setup lang="ts">
import { defineComponent, h } from 'vue'

// SVG icons inline — sin dependencias extra
const IconGrid = defineComponent({ render: () => h('svg', { viewBox:'0 0 24 24', fill:'none', stroke:'currentColor', 'stroke-width':'1.75' }, [
  h('rect',{x:'3',y:'3',width:'7',height:'7',rx:'1'}), h('rect',{x:'14',y:'3',width:'7',height:'7',rx:'1'}),
  h('rect',{x:'3',y:'14',width:'7',height:'7',rx:'1'}), h('rect',{x:'14',y:'14',width:'7',height:'7',rx:'1'})
])})
const IconChart = defineComponent({ render: () => h('svg', { viewBox:'0 0 24 24', fill:'none', stroke:'currentColor', 'stroke-width':'1.75' }, [
  h('path',{d:'M3 3v18h18'}), h('path',{d:'M7 16l4-4 4 4 4-6'})
])})
const IconBox = defineComponent({ render: () => h('svg', { viewBox:'0 0 24 24', fill:'none', stroke:'currentColor', 'stroke-width':'1.75' }, [
  h('path',{d:'M21 16V8a2 2 0 0 0-1-1.73l-7-4a2 2 0 0 0-2 0l-7 4A2 2 0 0 0 3 8v8a2 2 0 0 0 1 1.73l7 4a2 2 0 0 0 2 0l7-4A2 2 0 0 0 21 16z'}),
  h('polyline',{points:'3.27 6.96 12 12.01 20.73 6.96'}), h('line',{x1:'12',y1:'22.08',x2:'12',y2:'12'})
])})
const IconShop = defineComponent({ render: () => h('svg', { viewBox:'0 0 24 24', fill:'none', stroke:'currentColor', 'stroke-width':'1.75' }, [
  h('path',{d:'M6 2L3 6v14a2 2 0 0 0 2 2h14a2 2 0 0 0 2-2V6l-3-4z'}),
  h('line',{x1:'3',y1:'6',x2:'21',y2:'6'}), h('path',{d:'M16 10a4 4 0 0 1-8 0'})
])})
const IconUsers = defineComponent({ render: () => h('svg', { viewBox:'0 0 24 24', fill:'none', stroke:'currentColor', 'stroke-width':'1.75' }, [
  h('path',{d:'M17 21v-2a4 4 0 0 0-4-4H5a4 4 0 0 0-4 4v2'}), h('circle',{cx:'9',cy:'7',r:'4'}),
  h('path',{d:'M23 21v-2a4 4 0 0 0-3-3.87'}), h('path',{d:'M16 3.13a4 4 0 0 1 0 7.75'})
])})

const navItems = [
  { to: '/Kardex - Por Producto',            icon: IconGrid,  label: 'Kardex - Por Producto'   },
  { to: '/Existencias',      icon: IconChart, label: 'Existencias'      },
  { to: '/Kardex - General',  icon: IconGrid,   label: 'kardex-general'  },
  {to: '/dashboard', icon: IconChart, label: 'Dashboard' },

]
</script>