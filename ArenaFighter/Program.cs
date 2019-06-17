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
                Battle currentBattle = new Battle(userFighter);
                alive = currentBattle.Start();

                battleHistory.Add(currentBattle);

            }

        }

    } // End of class
} // End of namespace
