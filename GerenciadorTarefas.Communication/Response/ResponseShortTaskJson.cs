using TaskManager.Communication.Enum;

namespace TaskManager.Communication.Response;
public class ResponseShortTaskJson
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public StatusType Status { get; set; }

}

//information short