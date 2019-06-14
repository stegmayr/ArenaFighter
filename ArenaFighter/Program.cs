using System;
using System.Collections.Generic;

namespace ArenaFighter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool retired = false;
            bool winFight;
            List<Battle> battleHistory = new List<Battle>();


            Console.Write("\n----Welcome to Arena-Fighter----\n\nEnter a name for your fighter: ");
            Fighter userFighter = new Fighter(Console.ReadLine());

            while (!retired || userFighter.health > 0)
            {
                Battle currentBattle = new Battle(userFighter);
                winFight = currentBattle.Start();

                battleHistory.Add(currentBattle);

                if (winFight)
                {

                }

            }





        }

        /* public void Init()
        {
         
            
        } */






    } // End of class
} // End of namespace
