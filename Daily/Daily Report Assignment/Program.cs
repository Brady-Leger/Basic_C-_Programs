using System;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Academy of Learning Career College"); // Prints the college name
        Console.WriteLine("Student Daily Report"); // Prints what the program is
        Console.WriteLine("Please enter your name"); // Prints a prompt for the student to begin providing information, beginning with name.
        string name = Console.ReadLine(); // pauses the program so the student may answer the prompt. 
        Console.WriteLine("What course are you working on?");
        string course = Console.ReadLine();
        Console.WriteLine("Which page number?");
        string page = Console.ReadLine();
        Console.WriteLine("Do you need any assitance? Please answer \"True\" or \"False\" ");
        string help = Console.ReadLine();
        bool helpBool = bool.Parse(help); // Parses the answer given by the student to confirm they answered True or False.
        Console.WriteLine("Do you have any feedback you would like to provide, please be specific.");
        string feedback = Console.ReadLine();
        Console.WriteLine("How many hours did you study today? (Please enter an integer ie. 4)");
        string hoursStudied = Console.ReadLine();
        int hoursStudiedNum = Convert.ToInt32(hoursStudied); // Converts the int (hoursStudied) to a string
        Console.WriteLine("Thank you for your answers, an instructor will be with you shortly. Have a great day!");
            Console.ReadLine();
            
        }
    }
}
