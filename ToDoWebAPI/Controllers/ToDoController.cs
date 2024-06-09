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
        /*[HttpGet]
        public async Task<IActionResult> GetToDos()
        {
            var todos = await Mediatr.Send(new GetToDosQuery());
            return Ok(todos);
        }*/
        /*
        [HttpGet("{id}")]
        public async Task<IActionResult> GetToDoById(int id)
        {
            var todo = await Mediatr.Send(new GetToDoByIdQuery() { ToDoId = id});
            if(todo == null) 
                return NotFound();
            else
                return Ok(todo);
        }*/
        [HttpGet("{id}")]
        public async Task<IActionResult> GetToDoById(int id)
        { 
            var todo = await _queryDispatcher.QueryAsync(new GetToDoByIdQuery(){ ToDoId =  id});
            return Ok(todo);
        }

          /*  [HttpPost]
        public async Task<IActionResult> CreateToDo(CreateToDoCommand command)
        {
            var todo = await  Mediatr.Send(command);
            return CreatedAtAction(nameof(GetToDoById), new {Id = todo.Id}, todo);
        }

        [HttpPut("{id}")]

        public async Task<IActionResult> UpdateToDo(UpdateToDoCommand command,int id)
        {
            if(id != command.Id)
                return BadRequest();
            await Mediatr.Send(command);
            return NoContent();

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteToDo(int id)
        {
            await Mediatr.Send(new DeleteToDoCommand { ToDoId = id});
            return NoContent();
        }*/
    }
}
