using System;

namespace CSE210_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe");
            List<int> positionValues = new List<int>();
            int index = 1;
            while (index < 10)
            {
                positionValues.Add(index);
                ++index;
            }

            for (index = 0; index < positionValues.Count; index++)
            {
                Console.WriteLine(positionValues[index]);
            }



        }   
    }
}