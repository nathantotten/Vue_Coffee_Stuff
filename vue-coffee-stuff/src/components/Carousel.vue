<script setup lang="ts">
import CarouselContainer from '@/components/CarouselContainer.vue';
import CarouselTrack from '@/components/CarouselTrack.vue';


</script>

<template>
<CarouselContainer>
    <CarouselTrack>
        <slot>

        </slot>
    </CarouselTrack>
</CarouselContainer>
</template>

<style scoped>
.container {
    width: 100%;
    height: 100%;
    position: relative;
    overflow: clip;
}
</style>