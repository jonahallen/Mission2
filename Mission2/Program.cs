// See https://aka.ms/new-console-template for more information

using System;

//Create class to simulate the dice game
class DiceSimulator
{
    
    //Create a method to prompt the user for number of rolls and create an array of integers
    static void Main()
    {
        //Print welcome message
        Console.WriteLine("Welcome to the dice throwing simulator!");

        //Prompt user to enter number of rolls
        Console.Write("How many dice rolls would you like to simulate? ");
        int iNumRolls = int.Parse(Console.ReadLine());

        //Create an array of integers representing the rolls
        int[] aRolls = DiceRoller.RollDice(iNumRolls);

        //Call the PrintHistogram method
        PrintHistogram(aRolls, iNumRolls);

        //Print thank you message
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }

    //Create method to print the results in a histogram
    static void PrintHistogram(int[] aRolls, int iTotalRolls)
    {
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {iTotalRolls}.");

        //For loop to display the asteriks representing the percentage for each possible result
        for (int iCount = 2; iCount <= 12; iCount++)
        {
            int iPercentage = aRolls[iCount] * 100 / iTotalRolls;
            Console.WriteLine($"{iCount}: {new string('*', iPercentage)}");
        }
    }
}

//Create class to roll the dice
class DiceRoller
{
    //Create method that rolls the dice and returns an array with counts for each roll
    public static int[] RollDice(int iNumRolls)
    {
        Random random = new Random();
        int[] aRolls = new int[13];

        //Loop to generate a number between 1-6 for each die and add them to get the dice total
        for (int iCount = 0; iCount < iNumRolls; iCount++)
        {
            int iDice1 = random.Next(1, 7);
            int iDice2 = random.Next(1, 7);
            int iSumDice = iDice1 + iDice2;
            aRolls[iSumDice]++;
        }

        //Return the array
        return aRolls;
    }
}
