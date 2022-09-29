using MyFirstProject_MVC_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProject_MVC_Core.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandbyId(int id);
    }
}
