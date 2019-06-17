using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaFighter
{
    class Battle
    {
        Fighter opponent;
        Fighter player;

        public Battle(Fighter player)
        {
            this.player = player;
            this.opponent = new Fighter();
        }

        public bool Start()
        {
            while (player.health > 0 && opponent.health > 0)
            {
                BattleRound newBattleRound = new BattleRound(player, opponent);
                newBattleRound.Start();
            }

            if(player.health > 0)
            {
                player.health = player.health + 2;
            }

            return player.health > 0 ? true : false;
        }


    }
}
