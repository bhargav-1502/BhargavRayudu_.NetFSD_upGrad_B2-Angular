"use strict";
function getFirstElement(items) {
    return items[0];
}
class DataManager {
    items = [];
    add(item) {
        this.items.push(item);
    }
    getAll() {
        return this.items;
    }
}
const userManager = new DataManager();
userManager.add({ id: 1, name: "Rakesh" });
userManager.add({ id: 2, name: "Rahul" });
console.log("All Users:");
console.log(userManager.getAll());
console.log("First User:");
console.log(getFirstElement(userManager.getAll()));
const productManager = new DataManager();
productManager.add({ id: 101, title: "Laptop" });
productManager.add({ id: 102, title: "Mobile" });
console.log("All Products:");
console.log(productManager.getAll());
console.log("First Product:");
console.log(getFirstElement(productManager.getAll()));
