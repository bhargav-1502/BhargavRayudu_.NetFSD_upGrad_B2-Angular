"use strict";
class Employee {
    id;
    name;
    salary;
    constructor(id, name, salary) {
        this.id = id;
        this.name = name;
        this.salary = salary;
    }
    getSalary() {
        return this.salary;
    }
    setSalary(value) {
        if (value > 0) {
            this.salary = value;
        }
        else {
            console.log("Salary must be greater than 0");
        }
    }
    displayDetails() {
        console.log("Employee ID: " + this.id);
        console.log("Employee Name: " + this.name);
        console.log("Employee Salary: " + this.salary);
    }
}
class Manager extends Employee {
    teamSize;
    constructor(id, name, salary, teamSize) {
        super(id, name, salary);
        this.teamSize = teamSize;
    }
    displayDetails() {
        console.log("Manager ID: " + this.id);
        console.log("Manager Name: " + this.name);
        console.log("Manager Salary: " + this.getSalary());
        console.log("Team Size: " + this.teamSize);
    }
}
let emp1 = new Employee(1, "Rakesh", 30000);
emp1.displayDetails();
console.log("Updated Salary:");
emp1.setSalary(35000);
console.log(emp1.getSalary());
console.log("-------------------");
let mgr1 = new Manager(2, "Rahul", 60000, 8);
mgr1.displayDetails();
