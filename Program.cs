using System;

namespace Tomato
{
    class Program
    {
        static void Main(string[] args)
        {
            var wantsToPlay = true;
            while (wantsToPlay)
            {
                var currentGame = new Game();

                Console.WriteLine("Do you want to play another round?");
                var response = Console.ReadKey();
                if (response.KeyChar == 'n')
                {
                    wantsToPlay = false;
                }
            }

        }
    }
}
