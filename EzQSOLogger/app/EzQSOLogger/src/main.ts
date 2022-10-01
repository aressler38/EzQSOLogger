import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import WaveUI from 'wave-ui'

import 'wave-ui/dist/wave-ui.css'
//import './assets/main.css'


const app = createApp(App)

app.use(router)

new WaveUI(app, {})

app.mount('#app')
