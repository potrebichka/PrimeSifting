using System;
using System.Collections.Generic;

public class Program {
    public static void Main()
    {
        Console.WriteLine("Welcome to Prime Sifting Program!");
        while (true) {
            Console.WriteLine("Continue? [yes/no]");
            string answer = Console.ReadLine();
            if (answer == "no") {
                break;
            } 
            else if (answer == "yes")
            {
                Console.WriteLine("Enter number:");
                try 
                {
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetListOfNumbers(number));
                } 
                catch 
                {
                    Console.WriteLine("It is not a number");
                }
            }
            else {
                Console.WriteLine("Incorrect input");
            }

            
        }
        Console.WriteLine("Good-Bye");
    }

    private static string GetListOfNumbers(int number) {
        List<int> listOfNumbers = new List<int>();
        for (int i = 2; i <= number; i++) {
            listOfNumbers.Add(i);
        }
        int index = 0;
        int prime;
        while (index < listOfNumbers.Count) {
            prime = listOfNumbers[index];
            for (int i = listOfNumbers.Count-1; i > index; i--) {
                if (listOfNumbers[i] % prime == 0) {
                    listOfNumbers.Remove(listOfNumbers[i]);
                }
            }
            index++;
        }

        string result = ""; 
        foreach(int item in listOfNumbers)
        {
            result += item.ToString() + " ";
        };
        return result;
    }
}