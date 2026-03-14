using System;

namespace Week4Day4
{
    class ResultAnalyzer
    {
        public void CalculateResult(int m1, int m2, int m3, out int total, out double average)
        {
            total = m1 + m2 + m3;
            average = total / 3.0;
        }
    }

    internal class Student_Result_Analyzer_using_out_Parameters
    {
        static void Main()
        {
            ResultAnalyzer r = new ResultAnalyzer();
            char choice = 'y';

            do
            {
                Console.Write("Enter marks for subject1: ");
                int m1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter marks for subject2: ");
                int m2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter marks for subject3: ");
                int m3 = Convert.ToInt32(Console.ReadLine());

                if (m1 < 0 || m1 > 100 || m2 < 0 || m2 > 100 || m3 < 0 || m3 > 100)
                {
                    Console.WriteLine("Invalid marks. Marks must be between 0 and 100.");
                    continue;
                }

                int total;
                double average;

                r.CalculateResult(m1, m2, m3, out total, out average);

                Console.WriteLine("Total Marks = " + total);
                Console.WriteLine("Average Marks = " + average);

                if (average >= 40)
                    Console.WriteLine("Result = Pass");
                else
                    Console.WriteLine("Result = Fail");

                Console.Write("Do you want to enter another student? (y/n): ");
                choice = Convert.ToChar(Console.ReadLine());

            } while (choice == 'y' || choice == 'Y');
        }
    }
}