<template>
  <div class="hello">
    <h1>{{ msg }}</h1>
<button @click="Redirect" >Go and test the banckend</button>
  </div>
</template>

<script>
export default {
  data() {
    return {
      msg: "Boilerplate: VueJS 2 + ASP.NET MVC 5"
    };
  },
  methods: {
    Redirect() {
      this.$router.push("/APITest");
    }
  }
};
</script>

