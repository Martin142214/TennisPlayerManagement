using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCourse
{
    public class Facade
    {
        private TennisStrategy _tennisSystem;
        private FootballStrategy _footballSystem;
        private BasketballStrategy _basketballSystem;
        public List<Player> players;
        public Facade()
        {
            _tennisSystem = new TennisStrategy();
            _footballSystem = new FootballStrategy();
            _basketballSystem = new BasketballStrategy();
            players = new List<Player>();
        }

        public void TennisMethod(FactoryCreator creator, string name)
        {
            creator = new TennisPlayerCreator(players);
            Console.WriteLine("Tennis player creation:");
            _tennisSystem.Create(creator, name);
        }

        public void FootballMethod(FactoryCreator creator, string name)
        {
            creator = new FootballPlayerCreator(players);
            Console.WriteLine("Football player creation:");
            _footballSystem.Create(creator, name);
        }

        public void BasketballMethod(FactoryCreator creator, string name)
        {
            creator = new BasketballPlayerCreator(players);
            Console.WriteLine("Basketball player creation:");
            _basketballSystem.Create(creator, name);
        }
    }
}
