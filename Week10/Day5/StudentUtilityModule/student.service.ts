import { Student } from "./student.model";

export function getGrade(marks: number): string {
    if (marks >= 90) {
        return "A+";
    } else if (marks >= 75) {
        return "A";
    } else if (marks >= 60) {
        return "B";
    } else if (marks >= 40) {
        return "C";
    } else {
        return "Fail";
    }
}

export function getTopper(students: Student[]): Student {
    let topper: Student = students[0];

    for (let student of students) {
        if (student.marks > topper.marks) {
            topper = student;
        }
    }

    return topper;
}