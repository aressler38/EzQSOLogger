<script setup lang="ts">
import { RouterLink, RouterView } from 'vue-router'
import HelloWorld from './components/HelloWorld.vue'
import MainHeader from './components/MainHeader.vue'

</script>

<template>
  <w-app>
    <MainHeader></MainHeader>

    <!--
    <header>
      <img alt="Vue logo" class="logo" src="@/assets/logo.svg" width="125" height="125" />

      <div class="wrapper">
        <HelloWorld msg="You did it!" />

        <nav>
          <RouterLink to="/">Home</RouterLink>
          <RouterLink to="/about">About</RouterLink>
        </nav>
      </div>
    </header>
    -->

    <div class="wrapper">
      <RouterView />
    </div>
  </w-app>
</template>

<style scoped>
.wrapper {
  margin-top: 2.875em;
}
</style>
