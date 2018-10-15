<template>
        <div>
            <h1> {{product.name}} </h1>
            <img :src="product.thumbnail" :alt="product.name" />
            <p> {{product.description}} </p>
            <p> {{product.price}} </p>
        </div>
</template>

<script>
export default {
    name: "product-details",
    props: {
        product: {
            type: Object,
            required: true,
        }
    }
};
</script>

<style>
</style>
