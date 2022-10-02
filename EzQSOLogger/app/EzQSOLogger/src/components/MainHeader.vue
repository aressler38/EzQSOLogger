
<script setup lang="ts">
import { RouterLink, } from 'vue-router'
import { useUserStore } from '@/stores/userStore'

const userStore = useUserStore();
var env = process.env.NODE_ENV;
debugger;
</script>

<template>
  <w-toolbar height="2.875em" bg-color="blue-grey-light4" color="black" fixed>
    <RouterLink to="/" class="title2">EzQSOLogger</RouterLink>
    <div class="spacer"></div>
    <template v-if="userStore.user">
      <RouterLink to="/me">Me</RouterLink>
      <RouterLink to="/logout">Logout</RouterLink>
    </template>
    <RouterLink to="/login" v-else>Login</RouterLink>
  </w-toolbar>
</template>