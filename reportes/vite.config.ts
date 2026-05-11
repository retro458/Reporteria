import { fileURLToPath, URL } from 'node:url'
import { defineConfig, loadEnv } from 'vite'
import vue from '@vitejs/plugin-vue'

export default defineConfig(({ mode }) => {
  const env = loadEnv(mode, process.cwd())
  
  return {
    plugins: [vue()],
    resolve: {
      alias: {
        '@': fileURLToPath(new URL('./src', import.meta.url))
      }
    },
    build: {
      
      chunkSizeWarningLimit: 800,
      rollupOptions: {
        output: {
          // estrategia de fragmentación (chunking)
          manualChunks(id) {
            if (id.includes('node_modules')) {
              // Esto crea un archivo separado para las librerías externas
              return 'vendor';
            }
          }
        }
      }
    }
  }
})