let amount = 3500;;
let discount;

if (amount >= 5000) {
    discount = amount * 0.20;
} else if (amount >= 3000) {
    discount = amount * 0.10;
} else {
    discount = 0;
}

let finalAmount = amount - discount;

console.log("Discount: " + discount);
console.log("Final Payable Amount: " + finalAmount);
