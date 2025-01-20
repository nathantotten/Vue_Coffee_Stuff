<script setup lang="ts">
import { RouterLink } from 'vue-router';
</script>

<template>
  <nav class="navbar">
    <ul class="nav-list">
      <li><RouterLink to="/">Home</RouterLink></li>
      <li><RouterLink to="/about">About</RouterLink></li>
      <li><RouterLink to="/contact">Contact</RouterLink></li>
    </ul>
  </nav>
</template>

<style scoped>
.navbar {
  background-color: #333;
  color: #fff;
  padding: 1rem;
}

.nav-list {
  list-style: none;
  display: flex;
  gap: 1rem;
}

.nav-list li a {
  color: #fff;
  text-decoration: none;
  font-weight: bold;
}

.nav-list li a:hover {
  text-decoration: underline;
}
</style>
