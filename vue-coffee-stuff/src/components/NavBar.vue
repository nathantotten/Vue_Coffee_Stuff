<script setup lang="ts">
import { RouterLink } from 'vue-router';
</script>

<template>
  <nav class="navbar">
    <RouterLink to="/">
            <img alt="Coffee Cup" class="coffee-logo" src="@/assets/coffeecup.svg" width="125" height="125" />
    </RouterLink>
    <ul class="nav-list">
      <li><RouterLink to="/">Home</RouterLink></li>
      <li><RouterLink to="/about">About</RouterLink></li>
      <li><RouterLink to="/contact">Contact</RouterLink></li>
    </ul>
  </nav>
</template>

<style scoped>
.coffee-logo {
    padding-left: 1rem;
    transition: filter 0.3s ease;
    &:hover {
        filter: drop-shadow(0 0 10px rgba(255, 255, 255, 1.0));
    }
}

.navbar {
  background-color: #233d4d;
  color: #F2FDFF;
  border-radius: 1rem;
  padding: 1rem;
  display: flex;
  align-items: center;
}

.nav-list {
  list-style: none;
  display: flex;
  align-items: center;
  gap: 1rem;
}

.nav-list li a {
  color: #F2FDFF;
  text-decoration: none;
  font-weight: bold;
  padding: 1.25rem;
  border-radius: 10px;
  opacity: 90%;
  transition: background-color 0.3s ease;
}

.nav-list li a:hover {
    background-color: lightgray;
    color: #000;
    opacity: 100%;
}
</style>
