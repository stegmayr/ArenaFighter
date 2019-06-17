using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaFighter
{
    class Battle
    {
        Fighter opponent;
        Fighter player;
        string opponentName;
        bool win = false;

        public Battle(Fighter player)
        {
            this.player = player;
            this.opponent = new Fighter();
            opponentName = opponent.name;
        }

        public bool Start()
        {
            Console.Clear();
            Console.WriteLine("Player:\n" + player + "\n\nOpponent:\n" + opponent);

            while (player.health > 0 && opponent.health > 0)
            {
                Console.ReadKey();
                BattleRound newBattleRound = new BattleRound(player, opponent);
                newBattleRound.Start();
            }

            if(player.health > 0)
            {
                player.health = player.health + 2;
                win = true;
            }

            return player.health > 0 ? true : false;
        }

        public override string ToString()
        {
            return win == true ? $"{player.name} fought and killed {opponent.name}" : $"{player.name} was killed by {opponent.name}";
        }
    }
}
