<template>
 <div>
    <p>hello, let's test the banckend ...</p>
    <p><b> result: {{result}} </b></p>
  </div>
</template>

<script>
import axios from "axios";
export default {
  data() {
    return {
      result: ""
    };
  },
  created() {
    axios
      .get(`http://localhost:54490/APITest/Index`)
      .then(response => {
        this.result = response.data.message
      })
      .catch(error => {
        this.result = "check console";
        console.log(error);
      });
  }
};
</script>