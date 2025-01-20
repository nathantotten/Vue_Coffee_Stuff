<script setup lang="ts">
import { RouterView } from 'vue-router'
import { ref } from 'vue';
import Navbar from './components/Navbar.vue';

</script>

<template>
  <Navbar />
  <header>
    <div class="nav-wrapper">
      
    </div>
  </header>

  <div class="main-content">
    <RouterView />
  </div>
</template>

<style scoped>

</style>
