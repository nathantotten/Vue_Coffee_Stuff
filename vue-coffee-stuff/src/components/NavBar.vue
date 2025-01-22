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
      <li><RouterLink to="/machines">Coffee Machines</RouterLink></li>
      <li><RouterLink to="/about">About</RouterLink></li>
      <li><RouterLink to="/contact">Contact</RouterLink></li>
    </ul>
  </nav>
</template>

<style scoped>
.coffee-logo {
    /* padding: 0.5rem;
    border-style: none;
    border-radius: 50%;
    border-color: #723d46;
    transition: border 0.05s ease-in-out;
    &:hover {
      border-style: solid;      
    } */
}

.navbar {
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
  color: #723d46;
  background-color: #ffffff;
  border: #723d46;
  border-style: solid;
  border-width: 2px;
  border-radius: 1em;
  text-decoration: none;
  font-weight: bold;
  padding: 1.25rem;
  transition: background-color 0.2s ease;
}

.nav-list li a:hover {
    color: #ffffff;
    background-color: #723d46;
}
</style>
