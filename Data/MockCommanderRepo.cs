using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
           var Commands = new List<Command>
           {
               new Command{Id=0, HowTo="Boil an egg",Line="Boil Water",Platform="Kattle & Pan"},
               new Command{Id=1, HowTo="Cut Bread",Line="Get a knife",Platform="knife & chooping board"},
               new Command{Id=2, HowTo="ake Cup of tea",Line="Palce teabag in cup",Platform="Kattle & Cup"}

           };
           return Commands;
        }

        public Command GetCommandById(int Id)
        {
           return new Command{Id=0, HowTo="Boil an egg",Line="Boil Water",Platform="Kattle & Pan"};

        }
    }
}