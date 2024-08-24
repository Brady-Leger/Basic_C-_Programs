using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {

        //This is my Array the user will choose from
        string[] petArray = { "Dog", "Cat", "Fish", "Bird", "Lizard", "Horse" };
        //Asking the user to select a pet at random
        Console.WriteLine("Not sure what pet you want? Pick a number from 0-5 and let us decide!");
        int stringSelect = Convert.ToInt32(Console.ReadLine());
        bool validString = false;

        while (!validString)

        try
        {
            Console.WriteLine("You picked a " + petArray[stringSelect]);
            validString = true;
        }
        //The "Catch" will display an error message if theyt dont pick from 1-6
        catch
        {
            Console.WriteLine("You have provided an invalid entry. Please pick from 1-6.");
            stringSelect = Convert.ToInt32(Console.ReadLine());
        }


        //String Time
        List<string> wowClass = new List<string>()
        { "Warlock",
            "Warrior",
            "Monk",
            "Paladin",
            "Rogue",
            "Priest",
            "Shaman",
            "Demon Hunter",
            "Death Knight",
            "Mage",
            "Evoker",
            "Druid",
            "Hunter",
        };

        Console.WriteLine("\nSelect another number between 1-12 to find out what you're playing as your main in The War Within!");
        int listSelect = Convert.ToInt32(Console.ReadLine());
        bool validList = false;

        while (!validList)
        {
            try
            {
                Console.WriteLine("Your War Within Main is: " + wowClass[listSelect]);
                Console.ReadLine();
                validList = true;
            }
            //Error Message if they pick outside of 1-12
            catch
            {
                Console.WriteLine("Sorry, invalid selection. Please pick a number from 1-12");
                listSelect = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}

    //Asking for a new selection to determine their WoW Class


