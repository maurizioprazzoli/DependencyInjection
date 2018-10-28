using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            PartListCreator p = new PartListCreator();


            while (true)
            {
                Console.WriteLine("\nPress: \n A key to produce list parts \n Q quit");
                var userInput = Console.ReadLine();

                switch (userInput.ToUpper()[0])
                {
                    case 'A':
                        var parts = p.GetParts();
                        foreach (var part in parts)
                        {
                            Console.WriteLine(part);
                        }

                        break;

                    case 'Q':
                        return;
                }
            }
        }
    }
}
