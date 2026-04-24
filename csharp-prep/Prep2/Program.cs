using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("Provide your grade percentage for the class");
        string grade_input = Console.ReadLine();
        float grade_percent = float.Parse(grade_input);
        char letter;
        char? sign =null;
        if (grade_percent >= 90)
        {
            letter = 'A';
            Console.WriteLine("Congratulations on passing the course!");
            if ((grade_percent%10) < 3)
            {
                sign = '-';
            }
        }
        else if (grade_percent >= 80)
        {
            letter = 'B';
            Console.WriteLine("Congratulations on passing the course!");
            if ((grade_percent%10) >= 7)
            {
                sign = '+';
            }
            else if ((grade_percent%10) < 3)
            {
                sign = '-';
            }
        }
        else if (grade_percent >= 70)
        {
            letter = 'C';
            Console.WriteLine("Congratulations on passing the course!");
            if ((grade_percent%10) >= 7)
            {
                sign = '+';
            }
            else if ((grade_percent%10) < 3)
            {
                sign = '-';
            }
        }
        else if (grade_percent >= 60)
        {
            letter = 'D';
            Console.WriteLine("Unfortunately you have not passed this course, good luck next time.");
            if ((grade_percent%10) >= 7)
            {
                sign = '+';
            }
            else if ((grade_percent%10) < 3)
            {
                sign = '-';
            }
        }
        else
        {
            letter = 'F';
            Console.WriteLine("Unfortunately you have not passed this course, good luck next time.");
        }
        Console.WriteLine($"Your grade: {letter}{sign}");
    }
}