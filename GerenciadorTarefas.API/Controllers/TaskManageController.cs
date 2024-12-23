using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Aplication.UseCase.Tarefa.DeleteTask;
using TaskManager.Aplication.UseCase.Tarefa.GetAllTask;
using TaskManager.Aplication.UseCase.Tarefa.GetByIdTask;
using TaskManager.Aplication.UseCase.Tarefa.RegisterTask;
using TaskManager.Communication.Request;
using TaskManager.Communication.Response;

namespace TaskManager.API.Controllers;
[Route("api/[controller]")]
[ApiController]

public class TaskManageController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(List<ResponseShortTaskJson>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllTaskUseCaseJson();
        var response = useCase.Execute();

        if (response.Task.Any())
        {
            return Ok(response);
        }

        return NoContent();

    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterTaskJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestTaskJson request)
    {
        var response = new RegisterTaskJson().Execute(request);

        return Created(string.Empty, response);
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTaskJson),StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]

    public IActionResult Get(int id)
    {
        var useCase = new GetTaskById();

        var response = useCase.Execute(id);

        return Ok(response);

    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)] //Não encontrado

    public IActionResult Delete(int id)
    {
        var useCase = new DeleteTaskById();

        useCase.Execute(id);

        return NoContent();
    }
}
