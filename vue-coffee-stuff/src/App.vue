<script setup lang="ts">
import { RouterView } from 'vue-router'
import { ref } from 'vue';
import Navbar from './components/NavBar.vue';

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
