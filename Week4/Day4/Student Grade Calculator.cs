using System;

namespace Week4Day4
{
    class Student
    {
        public double CalculateAverage(int m1, int m2, int m3)
        {
            return (m1 + m2 + m3) / 3.0 ;
        }
    }
    internal class Student_Grade_Calculator
    {
        static void Main()
        {
            Student s = new Student();

            Console.Write("Enter marks for subject1: ");
            int m1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for subject2: ");
            int m2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks for subject3: ");
            int m3 = Convert.ToInt32(Console.ReadLine());

            double avg = s.CalculateAverage(m1, m2, m3);

            string grade;

            if (avg >= 80)
                grade = "A";
            else if (avg >=70 )
                grade = "B";
            else if (avg >= 60)
                grade = "C";
            else if (avg >= 50)
                grade = "D";
            else
                grade = "Fail";

            Console.WriteLine("Average = " + avg);
            Console.WriteLine("Grade = " + grade);

            Console.ReadLine();
        }
    }
}
