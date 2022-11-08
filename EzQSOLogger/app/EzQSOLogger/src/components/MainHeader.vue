
<script setup lang="ts">
import { RouterLink, } from 'vue-router'
import { useUserStore } from '@/stores/userStore'
const userStore = useUserStore();
var env = process.env.NODE_ENV;
userStore.loadUser();
</script>

<template>
  HELLO
  <w-toolbar height="2.875em" bg-color="blue-grey-light4" color="black" fixed>
    <RouterLink to="/" class="title2">EzQSOLogger</RouterLink>
    <div class="spacer"></div>
    <template v-if="userStore.user">
      <RouterLink to="/me">Me</RouterLink>
      &nbsp;
      /
      &nbsp;
      <a href="/.auth/logout">Logout</a>
    </template>
    <template v-else>
      <a href="/.auth/login/github">Login</a>
    </template>
  </w-toolbar>
</template>