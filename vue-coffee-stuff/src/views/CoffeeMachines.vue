<script setup lang="ts">
import ProductCard from '@/components/ProductCard.vue';
import { ref } from 'vue';
const products = ref(
    [
        {
            imageSource: '/images/machine1.jpeg',
            imageAltText: 'A coffee machine',
            productText: 'Great product number one!'
        },
        {
            imageSource: '/images/machine2.jpeg',
            imageAltText: 'Another coffee machine',
            productText: 'Not so good!'
        }
    ]
)
</script>

<template>
    <div class="coffee-machines">
        <h1>Browse our Coffee Machines</h1>
        <!-- <Carousel>
            <img src="/images/machine1.jpeg"/>
            <img src="/images/machine2.jpeg"/>
            <img src="/images/machine3.jpeg"/>
            <img src="/images/machine4.jpeg"/>
            <img src="/images/machine5.jpeg"/>
            <img src="/images/machine6.jpeg"/>
        </Carousel> -->
        <div v-for="machine in products" class="product-card">
            <ProductCard :imageSource="machine.imageSource" :productText="machine.productText"/>
        </div>
    </div>
</template>

<style scoped>

</style>