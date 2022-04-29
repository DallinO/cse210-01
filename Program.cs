using System;

namespace CSE210_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe");
            List<string> positionValues = new List<string>();
            int index = 1;
            while (index < 10)
            {
                positionValues.Add(index.ToString());
                index++;
            }
            
            Console.WriteLine($"\t {positionValues[0]} | {positionValues[1]} | {positionValues[2]}");
            Console.WriteLine($"\t---+---+---");
            Console.WriteLine($"\t {positionValues[3]} | {positionValues[4]} | {positionValues[5]}");
            Console.WriteLine($"\t---+---+---");
            Console.WriteLine($"\t {positionValues[6]} | {positionValues[7]} | {positionValues[8]}");

        }   
    }
}