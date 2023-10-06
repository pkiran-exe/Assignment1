using System;

class subjectsProgram
{
    static void Main(string[] args)
    {
        // Input marks for three subjects
        Console.Write("Enter marks for the first subject: ");
        int subject1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for the second subject: ");
        int subject2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for the third subject: ");
        int subject3 = Convert.ToInt32(Console.ReadLine());

        // Calculate total marks
        int totalMarks = subject1 + subject2 + subject3;

        // Calculate percentage
        double percentage = (double)totalMarks / 3;

        // Determine the grade based on the provided conditions
        string grade = "";

        if (percentage < 35)
            grade = "Fail";
        else if (percentage >= 35 && percentage < 45)
            grade = "Third";
        else if (percentage >= 45 && percentage < 60)
            grade = "Second";
        else
            grade = "First";

        // Display total marks, percentage, and grade
        Console.WriteLine("Total Marks: " + totalMarks);
        Console.WriteLine("Percentage: " + percentage + "%");
        Console.WriteLine("Grade: " + grade);
    }
}