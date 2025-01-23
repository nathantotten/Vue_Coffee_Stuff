<script setup lang="ts">
const props = defineProps<{ position: number }>();
</script>

<template>
<div class="track" :style="{ translate: `${props.position}rem` }">   
    <slot>
        
    </slot>
</div>
</template>

<style scoped>
.track {
    display: flex;
    max-width: fit-content;
    width: auto;
    height: 100%;
    position: absolute;
    inset: 0;
    transition: all 1s ease-in;

    &>* {
        width: auto;
        height: 100%;
        aspect-ratio: 1 / 1;
        object-fit: cover;
    }
}

</style>