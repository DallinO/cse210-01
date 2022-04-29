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

            for (index = 0; index < positionValues.Count; index++)
            {
                Console.WriteLine(positionValues[index]);
            }
            
            Console.WriteLine($"\t{positionValues[0]} | {positionValues[1]} | {positionValues[2]}");

        }   
    }
}