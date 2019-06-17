using System;
using System.Collections.Generic;

namespace ArenaFighter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool retired = false;
            bool alive = true;
            List<Battle> battleHistory = new List<Battle>();


            Console.Write("\n----Welcome to Arena-Fighter----\n\nEnter a name for your fighter: ");
            Fighter userFighter = new Fighter(Console.ReadLine());

            while (!retired && alive)
            {
                Console.Clear();
                Console.WriteLine(userFighter + "\n\nWhat do you want to do?\nH - Hunt for an opponent.\nR - Retire from fighting.");
                while (true)
                {
                    ConsoleKeyInfo result = Console.ReadKey();
                    if ((result.KeyChar == 'h') || (result.KeyChar == 'H'))
                    {
                        Battle currentBattle = new Battle(userFighter);
                        alive = currentBattle.Start();

                        battleHistory.Add(currentBattle);
                        break;
                    }
                    else if ((result.KeyChar == 'r') || (result.KeyChar == 'R'))
                    {
                        Console.WriteLine("\n\nYou have ended the violence by not fighting!");
                        retired = true;
                        break;
                    }
                }

            }

            Console.Clear();
            Console.WriteLine("Final Statistics: \n\n" + userFighter);

            for(int i = 0; i < battleHistory.Count; i++)
            {
                Console.WriteLine(battleHistory[i]);
            }

            Console.ReadKey();
        }

    } // End of class
} // End of namespace
