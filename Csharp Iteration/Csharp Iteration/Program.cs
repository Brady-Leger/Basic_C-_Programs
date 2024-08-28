using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    Console.WriteLine(names[j]);
            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

            //foreach (string name in names)
            //{
            //    if (name == "Jesse")
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            //List<int> passingScores = new List<int>();

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        passingScores.Add(score);
            //    }
            //}
            //Console.WriteLine(passingScores.Count);
            //Console.ReadLine();





            //Console App Assignment Part 1

            //string[] names = { "Brady", "Adia", "Misha", "Milo", "Maizie" };

            //Console.WriteLine("Type our last name.");
            //var response = Console.ReadLine();

            //for (int i = 0; i < names.Length; i++)
            //{
            //    names[i] = string.Concat(names[i], " ", response);
            //}
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();



            // Console App Assignment Part 2


            //while (true)
            //{
            //    Console.WriteLine("Hahahahahahhaha");
            //    break; //By putting break here it will print the console command once, then break the loop.
            //}
            //Console.ReadLine();

            //Console App Assignment Part 3

            //int[] spellingTestScores = { 8, 5, 2, 1, 1, 10, 7, 9 };

            // 3.1

            //for (int i = 0; i < spellingTestScores.Length; i++)
            //{
            //    if (spellingTestScores[i] > 6)
            //    {
            //        Console.WriteLine("Your Spelling Test Score is " + spellingTestScores[i] + "/10");
            //    }
            ////    Console.ReadLine();
            ////}

            //// 3.2

            //for (int i = 0; i < spellingTestScores.Length; i++)
            //{
            //    if (spellingTestScores[i] <= 6)
            //    {
            //        Console.WriteLine("Your Spelling Test Score is " + spellingTestScores[i] + "/10");
            //    }
            //    Console.ReadLine();
            //}

            // Console App Assignment 4

            //List<string> names = new List<string>() { "Brady", "Adia", "Misha", "Milo", "Maizie" };

            //Console.WriteLine("Type the name of one of our family members:");
            //string chosenName = Console.ReadLine();
            //Console.WriteLine("You chose " + chosenName); // This line prints out "You chose " + the info entered by the user.
            //Console.ReadLine();

            //bool inList = false;

            //foreach (string name in names)
            //{
            //    if (inList) // If the provided name is in the List the program ends.
            //    {
            //        break;
            //    }
            //    inList = chosenName == name; // This line evaluates the data provided against the names in the list to see if there is a match/
            //}
            //if (inList) // The if provides a response if the info provided is "true" whereas the else provides a response if the info is false.
            //{
            //    Console.WriteLine("Correct, you know who is in our family");
            //}
            //else
            //{
            //    Console.WriteLine("You seriously don't know who is in our family?");
            //}                       
            //Console.ReadLine();

            // Console App Assignment 5

            //List<string> colors = new List<string>() { "Blue", "Green", "Red", "Blue" };

            //Console.WriteLine("Try to guess one of 3 colors I am thinking of");
            //string chosenColor = Console.ReadLine();
            //Console.WriteLine("You chose " + chosenColor + " are you correct? Let's see!");
            //Console.ReadLine();

            //bool inList = false;

            //foreach (string color in colors)
            //{
            //    if (inList)
            //    {

            //    }
            //    inList = chosenColor == color;

            //}
            //if (inList)
            //{
            //    Console.WriteLine("You have correctly guessed one of the three colors.");
            //}
            //else
            //{
            //    Console.WriteLine("WRONG!");
            //}
            //Console.ReadLine();

            //Console app Assignment 6

            //List<string> letters = new List<string>() { "A", "B", "C", "D", "C", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            //List<string> duplicateCheck = new List<string>();
            //Console.WriteLine("I typed out each letter of The Alphabet once, let's make sure I didn't make any mistakes");

            ////this is a "foreach" loop that evaluates each item in the list and displays if it has or has not already appeared in the list.
            //foreach (string letter in letters)
            //{
            //    Console.WriteLine(letter);
            //    if (duplicateCheck.Contains(letter))
            //    {
            //        Console.WriteLine("DUPLICATE!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Good!");
            //    }
            //    duplicateCheck.Add(letter);
            //}
            //Console.ReadLine();
        }
    }
}
