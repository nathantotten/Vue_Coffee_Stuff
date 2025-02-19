import { createRouter, createWebHistory } from 'vue-router'
import About from "@/views/About.vue"
import Home from "@/views/Home.vue"
import Contact from "@/views/Contact.vue"
import CoffeeMachines from "@/views/CoffeeMachines.vue"
import Recipes from "@/views/Recipes.vue"

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {path: '/', name: 'home', component: Home},
    {path: '/about', name: 'about', component: About},
    {path: '/contact', name: 'contact', component: Contact},
    {path: '/coffeemachines', name: 'coffee machines', component: CoffeeMachines},
    {path: '/recipes', name: 'recipes', component: Recipes}
  ],
})

export default router
