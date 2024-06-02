using System;

namespace GradeCalculator
{
  class Program
  {
    static string gradeCalculator(int score) 
    {
        if(score >= 0 && score <= 100) {
            if(score >= 90) {
                return "A";
            } else if(score >= 80) {
                return "B";
            } else if(score >= 70) {
                return "C";
            } else if(score >= 60) {
                return "D";
            } else {
                return "F";
            }
        } else {
            return "invalid input";
        }
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Enter score:");

      string input = Console.ReadLine();

      int mark;
      if (int.TryParse(input, out mark)) {
          string grade = gradeCalculator(mark);
          string printOut = grade == "invalid input" ? "Wrong input entered!❌" : $"Your grade is: {grade}";
          Console.WriteLine(printOut);
      } else {
          Console.WriteLine("Invalid input. Please enter a valid integer score.");
      }
    }
  }
}
