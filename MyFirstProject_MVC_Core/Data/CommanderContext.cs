using Microsoft.EntityFrameworkCore;
using MyFirstProject_MVC_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MyFirstProject_MVC_Core.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt)  : base(opt)
        {

        }
        public DbSet<Command> Commands { get; set; }
    }
}
