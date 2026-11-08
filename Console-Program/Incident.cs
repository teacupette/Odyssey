using System.Text.Json.Serialization;
class Incident : MapObject
{
    [JsonInclude] private IncidentType type{get; set;}
    [JsonInclude] private IncidentStatus status{get; set;}
    [JsonInclude] private IncidentPriority priority{get; set;}
    [JsonInclude] private List<int> unitAssignement = new List<int>();
    [JsonInclude] private string description{get; set;} = "";

    public Incident(IncidentType type, IncidentStatus status, IncidentPriority priority, string description, int[] position): base(position)
    {
        this.type = type;
        this.status = status;
        this.priority = priority;
        this.description = description;

    }

    public void updateStatus(IncidentStatus status)
    {
        this.status = status;
    }

    public void updatePriority(IncidentPriority priority)
    {
        this.priority = priority;
    }

    public string getInformation()
    {
        return description; //this is just temporary
    }
}