import { createRouter, createWebHistory } from 'vue-router'
import About from "@/views/About.vue"
import Home from "@/views/Home.vue"
import CoffeeMachines from "@/views/CoffeeMachines.vue"
import Contact from "@/views/Contact.vue"

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {path: '/', name: 'home', component: Home},
    {path: '/machines', name: 'coffee machines', component: CoffeeMachines},
    {path: '/about', name: 'about', component: About},
    {path: '/contact', name: 'contact', component: Contact}
  ],
})

export default router
