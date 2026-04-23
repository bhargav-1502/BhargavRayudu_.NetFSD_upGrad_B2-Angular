class Employee {
    public id: number;
    protected name: string;
    private salary: number;

    constructor(id: number, name: string, salary: number) {
        this.id = id;
        this.name = name;
        this.salary = salary;
    }

    public getSalary(): number {
        return this.salary;
    }

    public setSalary(value: number): void {
        if (value > 0) {
            this.salary = value;
        } else {
            console.log("Salary must be greater than 0");
        }
    }

    public displayDetails(): void {
        console.log("Employee ID: " + this.id);
        console.log("Employee Name: " + this.name);
        console.log("Employee Salary: " + this.salary);
    }
}

class Manager extends Employee {
    public teamSize: number;

    constructor(id: number, name: string, salary: number, teamSize: number) {
        super(id, name, salary);
        this.teamSize = teamSize;
    }

    public displayDetails(): void {
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