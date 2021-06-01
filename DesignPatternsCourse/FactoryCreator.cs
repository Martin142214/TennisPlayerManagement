using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCourse
{
    public abstract class Player
    {
        public string _name;
        public Player(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
        public abstract void Display(string name);
    }

    public class TennisPlayer : Player
    {
        public TennisPlayer(string name) : base(name)
        {

        }

        public override void Display(string name)
        {
            Console.WriteLine($"{this.GetType().Name} {name} is created!");
        }
    }

    public class FootBallPlayer : Player
    {
        public FootBallPlayer(string name) : base(name)
        {

        }

        public override void Display(string name)
        {
            Console.WriteLine($"{this.GetType().Name} {name} is created!");
        }
    }

    public class BasketballPlayer : Player
    {
        public BasketballPlayer(string name) : base(name)
        {

        }

        public override void Display(string name)
        {
            Console.WriteLine($"{this.GetType().Name} {name} is created!");
        }
    }

    public abstract class FactoryCreator
    {
        List<Player> _players;

        public FactoryCreator(List<Player> players)
        {
            _players = players;     
        }

        public List<Player> Players
        {
            get { return _players; }
        }
        public abstract Player FactoryMethod(string name);
    }

    public class TennisPlayerCreator : FactoryCreator
    {
        public TennisPlayerCreator(List<Player> players) : base(players)
        {

        }
        public override Player FactoryMethod(string name)
        {
            var tPlayer = new TennisPlayer(name);
            this.Players.Add(tPlayer);
            var tName = tPlayer.GetName();
            tPlayer.Display(tName);
            return tPlayer;
        }
    }

    public class FootballPlayerCreator : FactoryCreator
    {
        public FootballPlayerCreator(List<Player> players) : base(players)
        {
                
        }
        public override Player FactoryMethod(string name)
        {
            var fPlayer = new FootBallPlayer(name);
            this.Players.Add(fPlayer);
            var fName = fPlayer.GetName();
            fPlayer.Display(fName);
            return fPlayer;
        }
    }

    public class BasketballPlayerCreator : FactoryCreator
    {
        public BasketballPlayerCreator(List<Player> players) : base(players)
        {
                
        }
        public override Player FactoryMethod(string name)
        {
            var bPlayer = new BasketballPlayer(name);
            this.Players.Add(bPlayer);
            var bName = bPlayer.GetName();
            bPlayer.Display(bName);
            return bPlayer;
        }
    }
}
