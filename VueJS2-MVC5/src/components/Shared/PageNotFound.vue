<template>
    <h1>404 ERROR - Page not Found</h1>
</template>

<script>
export default {
  created() {
    this.$router.push("/PageNotFound");
  }
};
</script>