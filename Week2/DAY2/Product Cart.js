const products = [
    { name: "Smartphone", price: 20000, quantity: 1 },
    { name: "Headphones", price: 2500, quantity: 2 },
    { name: "Power Bank", price: 1200, quantity: 3 },
    { name: "Smart Watch", price: 5000, quantity: 1 }
];

// Calculate Total Cart Value
const calculateTotal = (items) =>
    items.reduce((total, item) =>
        total + item.price * item.quantity, 0);

// Generate Invoice
const generateInvoice = (items) => {
    const total = calculateTotal(items);

    console.log(`
INVOICE SUMMARY
---------------------------
${items.map(item =>
    `${item.name} - ₹${item.price} x ${item.quantity} = ₹${item.price * item.quantity}`
).join("\n")}
---------------------------
Total Cart Value: ₹${total}
`);
};

generateInvoice(products);