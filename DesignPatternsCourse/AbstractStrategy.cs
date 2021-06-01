using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCourse
{
    public abstract class AbstractStrategy
    {
        public Player player; 
        public abstract Player Create(FactoryCreator creator, string name);
    }

    public class TennisStrategy : AbstractStrategy
    {
        public override Player Create(FactoryCreator creator, string name)
        {
            player = creator.FactoryMethod(name);
            return player;
        }
    }

    public class FootballStrategy : AbstractStrategy
    {
        public override Player Create(FactoryCreator creator, string name)
        {
            player = creator.FactoryMethod(name);
            return player;
        }
    }

    public class BasketballStrategy : AbstractStrategy
    {
        public override Player Create(FactoryCreator creator, string name)
        {
            player = creator.FactoryMethod(name);
            return player;
        }
    }
}
