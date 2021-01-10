using System;

namespace Tomato
{
    public class Game
    {
        private Player player;
        private Player opponent;
        public void Play()
        {
            Initialize();
            Loop();
        }

        public void Initialize()
        {
            player = new Player();
            opponent = new Player(true);
        }

        public void Loop()
        {
            while (player.Health >= 0)
            {
                player.Deck.LoadHand();
                player.Energy = 4;
                while (player.Energy >= 0)
                {
                    Console.WriteLine("\n-- Status --");
                    Console.WriteLine(player.Status);
                    Console.WriteLine(opponent.Status);

                    Console.WriteLine("\n1. Attack");
                    Console.WriteLine("2. Defend");
                    Console.WriteLine("3. Magic");
                    Console.WriteLine("\n0. End Turn");

                    var choice = Utilities.KeyPrompt("Selection: ");

                    switch (choice)
                    {
                        case '0':
                            player.Energy = -1;
                            break;
                        case '1':
                            var attack = player.Attack();
                            opponent.Health -= attack.Value;
                            player.Energy -= attack.Cost;
                            break;
                    }
                }
                player.Deck.EmptyHand();
                Console.WriteLine("Ended turn");
                player.Health -= opponent.Attack().Value;
            }
        }
    }
}