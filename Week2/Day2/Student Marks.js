const marks = [85, 78, 92, 88, 76];

const calculateTotal = (arr) =>
    arr.reduce((total, mark) => total + mark, 0);

const calculateAverage = (arr) =>
    calculateTotal(arr) / arr.length;

const displayResult = () => {
    const total = calculateTotal(marks);
    const average = calculateAverage(marks);
    const result = average >= 40 ? "PASS" : "FAIL";

    console.log(`
Student Marks Report
--------------------
Marks: ${marks.map(mark => mark).join(", ")}
Total: ${total}
Average: ${average.toFixed(2)}
Result: ${result}
`);
};

displayResult();


