<template>
<div>
<h1>Welcome to Hands on Vue.js with ASP.NET Core!</h1>
<p>
The time is: {{ time }}
</p>
<p>And the current users of this system are:</p>
<div v-if="!loading" >
<ul>
  <li v-for="user in users" :key="user.userName">
    {{ user.fullName }} - {{ user.userName }}
  </li>
</ul>
</div>
<span v-else> loading...</span>
</div>
</template>

<script>
export default {
  name: "app",
  data() {
    return {
      loading: true,
      time: new Date().toString(),
      users: []
    };
  },
  mounted() {
    fetch("/api/users")
      .then(res => res.json())
      .then(data => {
        this.users = data;
        this.loading = false;
      });
  }
};
</script>