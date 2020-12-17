using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsControllers : ControllerBase
    {
        private readonly ICommanderRepo _repository;

        public CommandsControllers(ICommanderRepo repository)
        {
            _repository = repository;
        }

        //Get api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAppCommands();
            return Ok(commandItems);
        }
         
         //Get api/commands/{id}
         [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int Id) 
        {
            var commandItem = _repository.GetCommandById(Id);
            return Ok(commandItem);

        }

    }
}