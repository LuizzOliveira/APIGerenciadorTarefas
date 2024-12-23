using System.Runtime.InteropServices;
using TaskManager.Communication.Response;

namespace TaskManager.Aplication.UseCase.Tarefa.GetAllTask;
public class GetAllTaskUseCaseJson
{
    public ResponseAllTaskJson Execute()
    {
        return new ResponseAllTaskJson
        {
            Task = new List<ResponseShortTaskJson>
            {
                new ResponseShortTaskJson 
                {

                    Id = 1,

                    Name = "Estudar",

                    Status = Communication.Enum.StatusType.InProgress

                }
            }
        };
    }
}