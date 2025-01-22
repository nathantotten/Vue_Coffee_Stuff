<script setup lang="ts">
</script>

<template>
<div class="track">   
    <slot>
        
    </slot>
</div>
</template>

<style scoped>
.track {
    width: 200%;
    height: 100%;
    position: absolute;
    inset: 0;
    transition: all 1s ease-in;
}

@keyframe scroll {
    0% {
        transform: translateX(-100%);
    }
    100% {
        transform: translateX(100%);
    }
}
</style>