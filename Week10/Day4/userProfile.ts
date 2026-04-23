const userName: string = "Sunil";
let age: number = 22;
const email: string = "sunil@gmail.com";
const isSubscribed: boolean = true;

let city = "Bangalore";
let loginCount = 3;

let message = `Hello ${userName}, you are ${age} years old and your email is ${email}`;

console.log(message);

age++;

let isEligibleForPremium = age > 18 && isSubscribed;

console.log("Updated Age:", age);
console.log("Eligible for Premium Plan:", isEligibleForPremium);
console.log("Age == 23:", age == 23);
console.log("Age > 18:", age > 18);
console.log("Age < 30:", age < 30);
console.log("Subscribed AND Adult:", isSubscribed && age > 18);
console.log("Subscribed OR Minor:", isSubscribed || age < 18);
console.log("Not Subscribed:", !isSubscribed);
console.log("City:", city);
console.log("Login Count:", loginCount);