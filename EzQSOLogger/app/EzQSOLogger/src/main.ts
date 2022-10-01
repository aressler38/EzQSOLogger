import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import WaveUI from 'wave-ui'
import { createPinia } from 'pinia'

import 'wave-ui/dist/wave-ui.css'
//import './assets/main.css'


const app = createApp(App)
const pinia = createPinia()

app.use(router)
app.use(pinia)

new WaveUI(app, {})

app.mount('#app')
