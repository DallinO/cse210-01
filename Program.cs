using System;

namespace CSE210_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe!\n");
            List<string> positionValues = new List<string>();
            for (int index = 1; index < 10; index++)
            {
                positionValues.Add(index.ToString());
                Console.WriteLine(positionValues[index -1]);
            }

            List<int> chosenPositions = new List<int>();
            chosenPositions.Add(0);

            float turn = 1;
            Display(positionValues, turn, chosenPositions);
            

        }   

        static void Display(List<string> positionValues, float turn, List<int> chosenPositions)
        {
            Console.WriteLine($"\t {positionValues[0]} | {positionValues[1]} | {positionValues[2]}");
            Console.WriteLine($"\t---+---+---");
            Console.WriteLine($"\t {positionValues[3]} | {positionValues[4]} | {positionValues[5]}");
            Console.WriteLine($"\t---+---+---");
            Console.WriteLine($"\t {positionValues[6]} | {positionValues[7]} | {positionValues[8]}\n");

            Turn(positionValues, turn, chosenPositions);

        }

        static void Turn(List<string> positionValues, float turn, List<int> chosenPositions)
        {

            if (turn == 10)
            {
                GameOver();
            }
            else if (turn % 2 == 0)
            {
                Console.Write("O's turn to choose a square (1-9): ");
                int square = int.Parse(Console.ReadLine());
                for (int index = 0; index < chosenPositions.Count; index++)
                {
                    if (square == chosenPositions[index])
                    {
                        Console.WriteLine("This square has already been used. Please select a different square.");
                        Turn(positionValues, turn, chosenPositions);
                    }
                    else if (index == (chosenPositions.Count - 1))
                    {
                        chosenPositions.Add(square);
                        break;
                    }
                }
                positionValues[square - 1] = "O"; 
                turn++;
                Display(positionValues, turn, chosenPositions);
            }
            else if (turn % 2 != 0)
            {
                Console.Write("X's turn to choose a square (1-9): ");
                int square = int.Parse(Console.ReadLine());
                for (int index = 0; index < chosenPositions.Count; index++)
                {
                    
                    if (square == chosenPositions[index])
                    {
                        Console.WriteLine("This square has already been used. Please select a different square.");
                        Turn(positionValues, turn, chosenPositions);
                    }
                    else if (index == (chosenPositions.Count - 1))
                    {
                        
                        chosenPositions.Add(square);
                        break;
                    }
                }
                positionValues[square - 1] = "X";
                turn++;
                Display(positionValues, turn, chosenPositions);
            }

            static void GameOver()
            {
                Console.WriteLine("Thats all their is folks!");

            }


        }
    }
}