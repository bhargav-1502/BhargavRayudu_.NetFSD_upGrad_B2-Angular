"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const student_service_1 = require("./student.service");
const utils_1 = require("./utils");
const constants_1 = require("./constants");
const students = [
    { id: 1, name: "rakesh", marks: 95 },
    { id: 2, name: "raju", marks: 72 },
    { id: 3, name: "kiran", marks: 38 },
    { id: 4, name: "anitha", marks: 84 }
];
console.log("PASS MARKS:", constants_1.PASS_MARKS);
console.log("\nStudent Details:");
for (let student of students) {
    console.log("ID:", student.id, "| Name:", (0, utils_1.formatName)(student.name), "| Marks:", student.marks, "| Grade:", (0, student_service_1.getGrade)(student.marks));
}
console.log("\nAverage Marks:", (0, utils_1.calculateAverage)(students));
const topper = (0, student_service_1.getTopper)(students);
console.log("\nTopper:", (0, utils_1.formatName)(topper.name), "-", topper.marks);
