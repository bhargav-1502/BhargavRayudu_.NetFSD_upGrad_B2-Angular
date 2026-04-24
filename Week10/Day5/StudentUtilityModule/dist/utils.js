"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.formatName = formatName;
exports.calculateAverage = calculateAverage;
function formatName(name) {
    return name.charAt(0).toUpperCase() + name.slice(1).toLowerCase();
}
function calculateAverage(students) {
    let total = 0;
    for (let student of students) {
        total += student.marks;
    }
    return total / students.length;
}
