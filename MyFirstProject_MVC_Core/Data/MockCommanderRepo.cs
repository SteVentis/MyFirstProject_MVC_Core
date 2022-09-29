using MyFirstProject_MVC_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProject_MVC_Core.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
               new Command { Id = 0, HowTo = "Boil an Egg", Line = "Boil water", Platform = "Kettle & Pan" },
               new Command { Id = 1, HowTo = "Cut Bread", Line = "Get a knife", Platform = "knife & chopping board" },
               new Command { Id = 2, HowTo = "Make cup of tea", Line = "Place teabag in cup", Platform = "Kettle & Cup" }
            };

            return commands;
        }

        public Command GetCommandbyId(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an Egg", Line = "Boil water", Platform = "Kettle & Pan" };
        }
    }
}
