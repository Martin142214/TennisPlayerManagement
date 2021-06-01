using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCourse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string tName = null;
            string fName = null;
            string bName = null;
            Facade facade = new Facade();
            List<Player> players = facade.players;
            TennisPlayerCreator tennisCreator = new TennisPlayerCreator(players);
            FootballPlayerCreator footballCreator = new FootballPlayerCreator(players);
            BasketballPlayerCreator basketballCreator = new BasketballPlayerCreator(players);
            Console.WriteLine("How many players you want to create?");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine($"Please choose the type of player {i+1}:");
                Console.WriteLine("1. Tennis player");
                Console.WriteLine("2. Football player");
                Console.WriteLine("3. Basketball player");
                int input = int.Parse(Console.ReadLine());
                if (input < 1 || input > 3)
                {
                    Console.WriteLine("Please input a valid number!");
                    input = int.Parse(Console.ReadLine());
                }
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Now type name for your tennis player:");
                        tName = Console.ReadLine();                      
                        facade.TennisMethod(tennisCreator, tName);
                        break;
                    case 2:
                        Console.WriteLine("Now type name for your football player:");
                        fName = Console.ReadLine();
                        facade.FootballMethod(footballCreator, fName);
                        break;
                    case 3:
                        Console.WriteLine("Now type name for your basketball player:");
                        bName = Console.ReadLine();
                        facade.BasketballMethod(basketballCreator, bName);
                        break;
                }
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("All created players:");
            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine($"{i+1}. {players[i].GetName()} --> {players[i].GetType().Name}");
            }
        }
    }
}
