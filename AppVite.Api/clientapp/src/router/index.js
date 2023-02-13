import { createWebHistory, createRouter } from "vue-router";
import FetchData from "./components/FetchData.vue";



const routes = [
    {
        path: "/",
        name: "FetchData",
        component: FetchData,
    }


];

const router = createRouter({
    history: createWebHistory(),
    routes,
});

export default router;
