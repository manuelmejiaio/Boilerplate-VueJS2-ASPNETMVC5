import Vue from 'vue'
import Router from 'vue-router'
import Home from '@/components/Home'
import APITest from '@/components/APITest'
import PageNotFound from '@/components/Shared/PageNotFound'

Vue.use(Router)

const routes = [

  { path: '/', name: 'Home', component: Home },
  { path: '/APITest', name: 'APITest', component: APITest },
  { path: "*", component: PageNotFound }
]

export default new Router({
  routes,
  mode: 'history'
})
