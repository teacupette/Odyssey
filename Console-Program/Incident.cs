class Incident : MapObject
{
    private IncidentType type{get; set;}
    private IncidentStatus status{get; set;}
    private IncidentPriority priority{get; set;}
    private List<EmergencyUnit> unitAssignement = new List<EmergencyUnit>();
    private string description{get; set;} = String.Empty;

    public Incident(IncidentType type, IncidentStatus status, IncidentPriority priority, string description, (int, int) position): base(position)
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