<script setup lang="ts">
import TheWelcome from '../components/TheWelcome.vue'
import QSOLogTableVue from '@/components/QSOLogTable.vue';
const fakeData = [{
  callsign: 'ke8ttk',
  frequency: '146.520MHz',
  mode: 'FM',
  time: new Date().toISOString(),
  signal: "s9"
}]
</script>

<script lang="ts">
export default {

  data() {
    return {
      counter: 0
    }
  },
  methods: {
    onClick() {
      ++this.counter;
    },
  },
  beforeRouteUpdate() {
  }
}
</script>

<template>
  <main>
    <!-- <TheWelcome /> -->
    hello, the counter is {{ counter }}
    <w-button @click="onClick()">Click me</w-button>

    <div></div>
    <QSOLogTableVue :initial-data="fakeData"></QSOLogTableVue>
  </main>
</template>

<style scoped>

</style>