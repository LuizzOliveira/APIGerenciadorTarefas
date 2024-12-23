using TaskManager.Communication.Enum;
using TaskManager.Communication.Response;

namespace TaskManager.Aplication.UseCase.Tarefa.GetByIdTask;
public class GetTaskById
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson
        {
            Name = "C#",

            Description = "EStudo .NET",

            Status = Communication.Enum.StatusType.InProgress,

            DateLimit = new DateTime(year: 2023, month: 01, day: 01),

            Priority = Communication.Enum.PriorityType.Medium
        };
    }
}
