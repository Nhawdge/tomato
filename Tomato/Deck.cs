using System;
using System.Collections.Generic;
using System.Linq;

namespace Tomato
{
    public class Deck
    {
        public List<Card> Hand { get; set; } = new List<Card>();
        public List<Card> DrawPile { get; set; } = new List<Card>();
        public List<Card> DiscardPile { get; set; } = new List<Card>();


        public Deck()
        {
            while (DrawPile.Count < 20)
            {
                Console.WriteLine("Generating New Card");
                DrawPile.Add(Card.Generate());
            }
        }
        public List<Card> AttackCards
        {
            get => Hand.Where(card => card.Type == CardType.Attack).ToList();
        }
        public void LoadHand()
        {
            var rand = new Random();
            for (int i = 0; i <= 6; i++)
            {
                if (DrawPile.Count == 0)
                {
                    DrawPile = DiscardPile;
                    DiscardPile.RemoveAll(x => true);
                }
                var next = rand.Next(0, DrawPile.Count);
                Hand.Add(DrawPile[next]);
                DrawPile.RemoveAt(next);
            }
        }

        public void HandToDiscard(int index)
        {
            DiscardPile.Add(Hand[index]);
            Hand.RemoveAt(index);
        }
        public void EmptyHand()
        {
            while (Hand.Count > 0)
            {
                HandToDiscard(0);
            }
        }
    }
}