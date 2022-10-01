import { fileURLToPath, URL } from 'node:url'

import { defineConfig } from 'vite'
import vue from '@vitejs/plugin-vue'
import fs from 'fs'

// https://vitejs.dev/config/
export default defineConfig({
    server: {
        https: {
            key: fs.readFileSync('../../key.pem'),
            cert: fs.readFileSync('../../cert.pem'),
        },
        watch: {
            useFsEvents: false,

            // Using polling in a docker container on WSL2
            usePolling: true,
            interval: 1000,
        }
    },
    plugins: [vue()],
    resolve: {
        alias: {
            '@': fileURLToPath(new URL('./src', import.meta.url))
        }
    }
})
