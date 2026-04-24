import { Student } from "./student.model";
import { getGrade, getTopper } from "./student.service";
import { formatName, calculateAverage } from "./utils";
import { PASS_MARKS } from "./constants";

const students: Student[] = [
    { id: 1, name: "rakesh", marks: 95 },
    { id: 2, name: "raju", marks: 72 },
    { id: 3, name: "kiran", marks: 38 },
    { id: 4, name: "anitha", marks: 84 }
];

console.log("PASS MARKS:", PASS_MARKS);

console.log("\nStudent Details:");

for (let student of students) {
    console.log(
        "ID:", student.id,
        "| Name:", formatName(student.name),
        "| Marks:", student.marks,
        "| Grade:", getGrade(student.marks)
    );
}

console.log("\nAverage Marks:", calculateAverage(students));

const topper: Student = getTopper(students);

console.log(
    "\nTopper:",
    formatName(topper.name),
    "-",
    topper.marks
);