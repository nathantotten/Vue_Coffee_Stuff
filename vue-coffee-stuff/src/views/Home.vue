<script setup lang="ts">
import { useThemeStore } from "@/stores/theme";

const store = useThemeStore();

</script>

<template>
  <div class="home">
    <h1>Welcome to the Home Page</h1>

    <!-- Theme Switcher testing -->
    <button type="button" @click="store.switchTheme">
      Switch Theme Here
    </button>
  </div>
</template>

<style scoped>

</style>
