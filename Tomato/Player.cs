using System;

namespace Tomato
{
    public class Player
    {
        public int Health { get; set; }
        public int Energy { get; set; }
        public Deck Deck { get; set; }
        private bool IsComputer { get; }


        public Player(bool isComputer = false)
        {
            IsComputer = isComputer;
            Health = 20;
            Energy = 5;
            Deck = new Deck();
        }

        public string Status { get => $"Health: {Health} | Energy: {Energy} "; }
        public Card Attack()
        {
            if (IsComputer)
            {
                var card = Card.Generate();
                Console.WriteLine("You are attack with " + card.Name);
                return card;
            }
            Console.WriteLine("Which Attack do you want to use?");
            int index = 0;
            foreach (var card in Deck.AttackCards)
            {
                index++;
                Console.WriteLine($"{index}. {card.Name}");
            }
            int choice = 0;
            var validChoice = false;
            while (!validChoice)
            {
                validChoice = int.TryParse(Utilities.Prompt("Selection: "), out choice);
            }

            var cardPicked = Deck.AttackCards[choice - 1];
            if (cardPicked != null)
            {
                Console.WriteLine("You attack with " + cardPicked.Name);
                Deck.HandToDiscard(choice - 1);
                return cardPicked;
            }
            else return Attack();
        }
    }
}