<script setup lang="ts">
import { RouterLink } from 'vue-router';
import { useThemeStore } from "@/stores/theme";

const store = useThemeStore();

</script>

<template>
  <div class="nav-container">
    <nav class="navbar">
      <RouterLink to="/">
        <svg xmlns="http://www.w3.org/2000/svg" width="100" height="100" viewBox="0 0 24 24">
          <g fill="none" class="logo" stroke-linecap="round" stroke-linejoin="round" stroke-width="1.5">
              <path d="M17 11.6V15a6 6 0 0 1-6 6H9a6 6 0 0 1-6-6v-3.4a.6.6 0 0 1 .6-.6h12.8a.6.6 0 0 1 .6.6M12 9c0-1 .714-2 2.143-2v0A2.857 2.857 0 0 0 17 4.143V3.5M8 9v-.5a3 3 0 0 1 3-3v0a2 2 0 0 0 2-2V3"/>
              <path d="M16 11h2.5a2.5 2.5 0 0 1 0 5H17"/>
          </g>
        </svg>
      </RouterLink>
      <ul class="nav-list">
        <li><RouterLink to="/">Home</RouterLink></li>
        <li><RouterLink to="/coffeemachines">Coffee Machines</RouterLink></li>
        <li><RouterLink to="/about">About</RouterLink></li>
        <li><RouterLink to="/contact">Contact</RouterLink></li>
      </ul>
    </nav>
    <!-- Theme Switcher testing -->
    <button type="button" @click="store.switchTheme" class="theme-button">
      Switch Theme Here
    </button>
  </div>
</template>

<style scoped>
/* Logo styling for each mode */
.light .logo {
  stroke: #49475B;
}

.dark .logo {
  stroke: white;
}

/* Link styling */
li a {
  text-decoration: none;
  border-style: solid;
  padding: 0.5rem;
  background-clip: border-box;
  border-radius: 15px;
  transition: background-color 0.2s ease-in-out;
  cursor: pointer; 
}

/* List item styling */
li {
  padding: 0.5rem;
}

/* dark link styling */
.dark li a {
  color: #ffffff;
  border-color: #ffffff;
  background-color:#49475B;
}

/* dark link hover styling */
.dark li a:hover {
  background-color: #ffffff;
  /* border-color: #49475B; */
  color:#49475B;
}

/* light link styling */
.light li a {
  color: #000;
  border-color: #49475B;
  background-color: #ffffff;
}

/* light link hover styling */
.light li a:hover {
  background-color: #49475B;
  color: #ffffff;
}

.nav-list {
  display: flex;
  flex-direction: row;
  list-style: none;
}

.navbar {
  padding: 1rem;
  display: flex;
  flex-direction: row;
  align-items: center;
}

.nav-container {
  display: flex;
  flex-direction: row;
  align-items: center;
}

.theme-button {
  margin-left: auto; /* send it alll the way to the right */
  padding: 0.75rem 1.5rem; 
  border: none; 
  border-radius: 15px;
  font-size: 1rem;
  font-weight: bold;
  cursor: pointer;
  transition: background-color 0.3s, transform 0.2s ease-in-out; /* neato hover effects */
}

.dark .theme-button {
  color: #49475B;
  background-color: #ffffff;
}

.light .theme-button {
  background-color: #49475B; /* Neutral dark for light theme */
  color: #ffffff;
}

.theme-button:hover {
  background-color: #69677C; /* Slightly lighter on hover */
  transform: scale(1.05); /* Subtle pop effect */
}

.dark .theme-button:hover {
  color: #ffffff;
}

.theme-button:active {
  transform: scale(0.95); /* Feedback for clicking */
}

.dark .theme-button:focus {
  outline: 2px solid #ffffff; /* Visible outline for accessibility */
  outline-offset: 3px;
}

.light .theme-button:focus {
  outline: 2px solid #49475B; /* Visible outline for accessibility */
  outline-offset: 3px;
}

</style>
