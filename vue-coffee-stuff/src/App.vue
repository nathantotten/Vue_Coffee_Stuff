<script setup lang="ts">
import { RouterView } from 'vue-router'
import { ref } from 'vue';
import Navbar from './components/NavBar.vue';

</script>

<template>
  
  <header>
    <div class="nav-wrapper">
      <Navbar />    
    </div>
  </header>

  <div class="main-content">
    <RouterView />
  </div>
</template>

<style scoped>
.nav-wrapper {
  background-color: #ffffff;
  border-radius: 0.5rem;
}
</style>
