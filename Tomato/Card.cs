using System;

namespace Tomato
{
    public class Card
    {
        public CardType Type { get; set; }
        public int Value { get; set; }
        public int Cost { get; set; }
        public string Name { get; set; }
        public static Card Generate()
        {
            Random random = new Random();

            var attack = random.Next(1, 5);
            var cost = random.Next(1, attack);
            var name = $"{Prefixes[random.Next(0, Prefixes.Length)]} {MoveName[random.Next(0, MoveName.Length)]} {Suffixes[random.Next(0, Suffixes.Length)]} [{attack}/{cost}]";
            return new Card()
            {
                Name = name,
                Type = CardType.Attack,
                Value = attack,
                Cost = cost
            };
        }

        static string[] Prefixes = { "Hurty", "Stabby" };
        static string[] MoveName = { "Attack", "Stab" };
        static string[] Suffixes = { "of Stabbing", "of Pain" };
    }
}