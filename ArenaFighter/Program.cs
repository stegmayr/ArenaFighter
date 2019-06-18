using System;
using System.Collections.Generic;
using Lexicon.CSharp;

namespace ArenaFighter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool retired = false;
            bool alive = true;
            int gameScore = 0;
            List<Battle> battleHistory = new List<Battle>();


            Console.Write("\n----Welcome to Arena-Fighter----\n\nEnter a name for your fighter: ");
            Fighter userFighter = new Fighter(Console.ReadLine().Trim());

            while (!retired && alive)
            {
                Console.Clear();
                Console.WriteLine(userFighter + "\n\nWhat do you want to do?\nH - Hunt for an opponent.\nR - Retire from fighting.");

                while (true)
                {
                    ConsoleKeyInfo result = Console.ReadKey();
                    if ((result.KeyChar == 'h') || (result.KeyChar == 'H'))
                    {
                        gameScore = gameScore + 2;
                        Battle currentBattle = new Battle(userFighter);
                        alive = currentBattle.Start();

                        if (alive)
                        {
                            gameScore = gameScore + 3;
                        }

                        battleHistory.Add(currentBattle);
                        break;
                    }
                    else if ((result.KeyChar == 'r') || (result.KeyChar == 'R'))
                    {
                        gameScore = gameScore + 4;
                        Console.WriteLine("\n\nYou have ended the violence by not fighting!");
                        retired = true;
                        break;
                    }
                }

            }

            Console.Clear();
            Console.WriteLine("Final Statistics: \n\n" + userFighter);

            for (int i = 0; i < battleHistory.Count; i++)
            {
                Console.WriteLine(battleHistory[i]);
            }

            Console.WriteLine($"{userFighter.name} total score is {gameScore}.");

            Console.ReadKey();
            Console.Clear();
        }

    } // End of class
} // End of namespace
