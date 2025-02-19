<script setup lang="ts">
</script>

<template>
  <div class="receipes">
    <div class="recipes-header">
        <h1>Welcome to the Recipes Page</h1>
    </div>
    <div class="recipe-nav">
        <div class="nav-item">
            My Recipes
        </div>
        <div class="nav-item">
            Community Recipes
        </div>
    </div>
  </div>
</template>

<style scoped>

.recipes-header {
    text-align: center;
    padding: 1rem;
}

.recipe-nav {
    max-width: 15%;
    display: flex;
    flex-direction: column;
    align-items: center;
}

.nav-item {
    border: 2px solid white;
    border-radius: 10px;
    min-width: 100%;
    margin: 0.5rem;
    padding: 0.5rem;
    font-weight: bold;
    transition: background-color 0.1s ease-in-out;
    align-items: center;
    text-align: center;
}

.light .nav-item {
    border-color: black;
}

.dark .nav-item {
    border-color: white;
}

.dark .nav-item:hover {
    background-color: white;
    color: black;
}

.light .nav-item:hover {
    background-color: black;
    color: white;
}
</style>
