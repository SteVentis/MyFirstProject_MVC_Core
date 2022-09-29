using Microsoft.AspNetCore.Mvc;
using MyFirstProject_MVC_Core.Data;
using MyFirstProject_MVC_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProject_MVC_Core.Controllers
{
    //api/commands
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase // For MVC Controllers without view support
    {
        private readonly ICommanderRepo _repository;

        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
        }
        
        //private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        //GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();

            return Ok(commandItems);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandbyId(id);

            return Ok(commandItem);
        }


    }
}
