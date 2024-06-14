using Convey.CQRS.Commands;
using Convey.CQRS.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoWebAPI.Application.ToDos.Commands.CreateToDo;
using ToDoWebAPI.Application.ToDos.Commands.DeleteToDo;
using ToDoWebAPI.Application.ToDos.Commands.UpdateToDo;
using ToDoWebAPI.Application.ToDos.Query.GetToDoById;
using ToDoWebAPI.Application.ToDos.Query.GetToDos;
using ToDoWebAPI.Domain.Entities;

namespace ToDoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ApiController
    {
        private readonly ICommandDispatcher _commandDispatcher;
        private readonly IQueryDispatcher _queryDispatcher;

        public ToDoController(ICommandDispatcher commandDispatcher,IQueryDispatcher queryDispatcher)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetToDos()
        {
            var todos = await _queryDispatcher.QueryAsync(new GetToDosQuery());
            return Ok(todos);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetToDoById([FromQuery]GetToDoByIdQuery query)
        {
            var todo = await _queryDispatcher.QueryAsync(new GetToDoByIdQuery() { ToDoId = query.ToDoId});
            return Ok(todo);
        }

        [HttpPost]
        public async Task<ActionResult> CreateToDo(CreateToDoCommand command)
        {
            
            await _commandDispatcher.SendAsync(command);
            return CreatedAtAction(nameof(GetToDoById), new {Id = command.Id},null);
        }
        
        [HttpPut("{id}")]

        public async Task<ActionResult> UpdateToDo(UpdateToDoCommand command,int id)
        {
            if(id != command.Id)
            {
                return BadRequest();
            }
            await _commandDispatcher.SendAsync(command);
            return NoContent();

        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteToDo(DeleteToDoCommand command)
        {
            
                await _commandDispatcher.SendAsync(command);
                return NoContent();
            
            
        }
    }
}
