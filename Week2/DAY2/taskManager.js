let tasks = [];

// Callback Version
const addTaskCallback = (task, callback) => {
    setTimeout(() => {
        tasks.push(task);
        callback(`Task "${task}" added.`);
    }, 1000);
};

// Promise Version
const addTaskPromise = (task) => {
    return new Promise((resolve) => {
        setTimeout(() => {
            tasks.push(task);
            resolve(`Task "${task}" added.`);
        }, 1000);
    });
};

// Async/Await Version
const addTask = async (task) => {
    const message = await addTaskPromise(task);
    console.log(message);
};

const deleteTask = async (taskName) => {
    return new Promise((resolve) => {
        setTimeout(() => {
            tasks = tasks.filter(task => task !== taskName);
            resolve(`Task "${taskName}" deleted.`);
        }, 1000);
    });
};

const listTasks = async () => {
    return new Promise((resolve) => {
        setTimeout(() => {
            resolve(`
Task List
---------
${tasks.map((task, index) => `${index + 1}. ${task}`).join("\n")}
`);
        }, 1000);
    });
};

(async () => {
    await addTask("Practice Cricket");
    await addTask("Practice Football");
    console.log(await listTasks());

    console.log(await deleteTask("Practice Football"));
    console.log(await listTasks());
})();
