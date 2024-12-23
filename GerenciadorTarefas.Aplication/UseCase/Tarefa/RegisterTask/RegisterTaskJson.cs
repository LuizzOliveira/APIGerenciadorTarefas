using TaskManager.Communication.Request;
using TaskManager.Communication.Response;

namespace TaskManager.Aplication.UseCase.Tarefa.RegisterTask;
public class RegisterTaskJson
{
    public ResponseRegisterTaskJson Execute(RequestTaskJson request)
    {

        return new ResponseRegisterTaskJson
        {
            Id = 7,
            Name = "Devocional"
        };
    }
}