const addResourcesToCache = async (resources) => {
    //const cache = await caches.open("v1");
    //await cache.addAll(resources);
};

console.log("I AM INSTALLING")
self.addEventListener("install", (event) => {
    console.log("I AM INSTALLING")
    /*
    event.waitUntil(
        addResourcesToCache([
        ])
    );
    */
});