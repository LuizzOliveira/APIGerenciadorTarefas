using TaskManager.Communication.Enum;

namespace TaskManager.Communication.Response;
public class ResponseTaskJson
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public StatusType Status { get; set; }

    public DateTime DateLimit { get; set; }

    public PriorityType Priority { get; set; }

}
