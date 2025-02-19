<script setup lang="ts">
import { ref } from "vue";

defineProps<{
    imageSource: string,
    imageAltText?: string,
    productText: string
}>();

</script>

<template>
<div class="product-card">
    <div class="product-content-wrapper">
        <div class="product-image-box">
            <img class="product-image" :src="imageSource" :alt="imageAltText || 'Product Image'">
        </div>

        <div class="product-info-box">
            <p class="product-text">{{ productText }}</p>
        </div>
    </div>
</div>
</template>

<style scoped>
.product-card {
    margin: 1.5rem;
    transition: transform 0.3s ease-in-out; /* Smooth transition */
}

.product-card:hover {
  transform: scale(1.01); /* Enlarges by 1% */
  cursor: pointer;
}

.product-image-box {
    display: flex;
    align-items: center;
    padding: 0.5rem;
}

.product-image {
    width: 150px;
    height: 150px;
    object-fit: cover;
    border-radius: 10px;
}

.product-info-box {
    padding: 0.5rem;
}

.product-content-wrapper {
    border: 2px solid;
    border-radius: 15px;
    display: flex;
    align-items: center;
    box-shadow: 0px 10px 10px rgba(0, 0, 0, 0.25);
}
</style>