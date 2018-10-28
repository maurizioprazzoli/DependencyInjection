using System;

namespace DependencyInjection_Refactoring_Step1
{
    class Program
    {
        static void Main(string[] args)
        {

            DatabaseService databaseService = new DatabaseService();
            PartListCreator p = new PartListCreator(databaseService);

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
