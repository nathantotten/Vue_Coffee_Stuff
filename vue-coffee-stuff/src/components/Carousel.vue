<script setup lang="ts">
import CarouselContainer from '@/components/CarouselContainer.vue';
import CarouselTrack from '@/components/CarouselTrack.vue';
import { ref } from 'vue';

const position = ref(0)

const goLeft = () => {
    position.value -= 15;
}

const goRight = () => {
    position.value += 15;
}

</script>

<template>
<CarouselContainer>
    
    <CarouselTrack :position>
        <slot>

        </slot>
    </CarouselTrack>

    <button type="button" class="car-btn-left" @click="goLeft">
        < Left
    </button>
    <button type="button" class="car-btn-right" @click="goRight">
        right >
    </button>
</CarouselContainer>
</template>

<style scoped>
.container {
    width: 75rem;
    height: 15rem;
    position: relative;
    overflow: clip;
}

.car-btn-left {
    position: absolute;
    left: 0;
    top: 50%;
}

.car-btn-right {
    position: absolute;
    right: 0;
    top: 50%;
}
</style>