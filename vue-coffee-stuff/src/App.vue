<script setup lang="ts">
import { RouterView } from 'vue-router'
import { ref } from 'vue';
import Navbar from './components/Navbar.vue';

</script>

<template>
  <header>
    <img alt="Coffee Cup" class="logo" src="@/assets/coffeecup.svg" width="125" height="125" />
    
    <div class="nav-wrapper">
      <Navbar />
    </div>
  </header>

  <div class="main-content">
    <RouterView />
  </div>
</template>

<style scoped>

</style>
