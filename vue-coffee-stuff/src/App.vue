<script setup lang="ts">
import { RouterView } from 'vue-router'
import { ref } from 'vue';
import Navbar from './components/NavBar.vue';

import { useThemeStore } from "@/stores/theme";

const store = useThemeStore();

</script>

<template>
  <div>
    <header>
      <div class="nav-wrapper">
        <Navbar />    
      </div>
    </header>

    <div class="main-content">
      <RouterView />
    </div>
  </div>
</template>

<style scoped>

</style>
