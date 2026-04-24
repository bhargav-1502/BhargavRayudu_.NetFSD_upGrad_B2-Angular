function getFirstElement<T>(items: T[]): T {
    return items[0];
}

interface Repository<T> {
    add(item: T): void;
    getAll(): T[];
}

class DataManager<T> implements Repository<T> {
    private items: T[] = [];

    add(item: T): void {
        this.items.push(item);
    }

    getAll(): T[] {
        return this.items;
    }
}

interface User {
    id: number;
    name: string;
}

interface Product {
    id: number;
    title: string;
}

const userManager = new DataManager<User>();

userManager.add({ id: 1, name: "Rakesh" });
userManager.add({ id: 2, name: "Rahul" });

console.log("All Users:");
console.log(userManager.getAll());

console.log("First User:");
console.log(getFirstElement(userManager.getAll()));

const productManager = new DataManager<Product>();

productManager.add({ id: 101, title: "Laptop" });
productManager.add({ id: 102, title: "Mobile" });

console.log("All Products:");
console.log(productManager.getAll());

console.log("First Product:");
console.log(getFirstElement(productManager.getAll()));