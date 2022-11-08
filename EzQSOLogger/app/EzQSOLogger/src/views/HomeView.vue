<script setup lang="ts">
import TheWelcome from '../components/TheWelcome.vue'
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
    console.log("HELLO")
  }
}


</script>

<template>
  <main>
    <!-- <TheWelcome /> -->
    hello, the counter is {{ counter }}
    <w-button @click="onClick()">Click me</w-button>
  </main>
</template>

<style scoped>

</style>