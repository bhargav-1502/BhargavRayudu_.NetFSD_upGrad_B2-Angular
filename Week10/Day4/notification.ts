function getWelcomeMessage(name: string): string {
    return `Welcome to our app, ${name}!`;
}

function getUserInfo(name: string, age?: number): string {
    if (age !== undefined) {
        return `User Name: ${name}, Age: ${age}`;
    }
    return `User Name: ${name}`;
}

function getSubscriptionStatus(
    name: string,
    isSubscribed: boolean = false
): string {
    if (isSubscribed) {
        return `${name} is subscribed to premium services.`;
    }
    return `${name} is not subscribed.`;
}

function isEligibleForPremium(age: number): boolean {
    return age >= 18;
}

const getAccountUpdate = (name: string): string => {
    return `Hello ${name}, your account has been updated successfully.`;
};

const notificationService = {
    appName: "NotifyHub",

    showAppMessage: (): string => {
        return `Welcome to ${notificationService.appName}`;
    }
};

console.log(getWelcomeMessage("Sunil"));
console.log(getUserInfo("Sunil", 22));
console.log(getUserInfo("Rahul"));
console.log(getSubscriptionStatus("Sunil", true));
console.log(getSubscriptionStatus("Rahul"));
console.log(isEligibleForPremium(20));
console.log(isEligibleForPremium(15));
console.log(getAccountUpdate("Sunil"));
console.log(notificationService.showAppMessage());