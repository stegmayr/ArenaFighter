using System;
using System.Collections.Generic;
using System.Text;

namespace ArenaFighter
{
    class BattleRound
    {
        Fighter player;
        Fighter opponent;

        public BattleRound(Fighter player, Fighter opponent)
        {
            this.player = player;
            this.opponent = opponent;
        }

        public void Start()
        {
            Random dice = new Random();
            int diceRollUser = dice.Next(1, 7);
            int diceRollOpponent = dice.Next(1, 7);

            if (player.strength + diceRollUser < opponent.strength + diceRollOpponent)
            {
                player.health = player.health - opponent.damage;


                Console.Write($"\n--------------\nRolls: {player.name} {player.strength + diceRollUser} ({diceRollUser}+{player.strength}) vs {opponent.name} {opponent.strength + diceRollOpponent} ({diceRollOpponent}+{opponent.strength})\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{opponent.name} attacks {player.name}! {player.name} takes {opponent.damage} damage{(player.health > 0 ? "." : ", and falls to the graound dead!")}");
                Console.ResetColor();
                Console.Write($"Remaning health: {player.name} ({player.health}), {opponent.name} ({opponent.health}).\n");

            }
            else if (player.strength + diceRollUser > opponent.strength + diceRollOpponent)
            {
                opponent.health = opponent.health - player.damage;

                Console.Write($"\n--------------\nRolls: {player.name} {player.strength + diceRollUser} ({diceRollUser}+{player.strength}) vs {opponent.name} {opponent.strength + diceRollOpponent} ({diceRollOpponent}+{opponent.strength})\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{player.name} attacks {opponent.name}! {opponent.name} takes {player.damage} damage{(opponent.health > 0 ? "." : ", and falls to the graound dead!")}");
                Console.ResetColor();
                Console.Write($"Remaning health: {player.name} ({player.health}), {opponent.name} ({opponent.health}).\n");
            }
            else
            {
                Console.Write($"\n--------------\nRolls: {player.name} {player.strength + diceRollUser} ({diceRollUser}+{player.strength}) vs {opponent.name} {opponent.strength + diceRollOpponent} ({diceRollOpponent}+{opponent.strength})\nEvenly matched, the combatants circel each other, looking for a better opportunity.\nRemaning Health: {player.name} ({player.health}), {opponent.name} ({opponent.health}).\n");
            }
        }
    }

}
