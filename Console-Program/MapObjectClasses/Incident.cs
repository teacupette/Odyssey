using System.Text.Json.Serialization;
class Incident : MapObject, IgetId
{
    private static int incidentIdCounter = 0;
    [JsonInclude] private int incidentId{get; set;}
    [JsonInclude] private IncidentType type{get; set;}
    [JsonInclude] private IncidentStatus status{get; set;}
    [JsonInclude] private IncidentPriority priority{get; set;}
    [JsonInclude] private string description{get; set;} = "";
    [JsonInclude] private List<int> assignedUnitIds = new List<int>();

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

    public string getDescripion()
    {
        return description; //this is just temporary
    }

    public int getId()
    {
        return incidentId;
    }
}