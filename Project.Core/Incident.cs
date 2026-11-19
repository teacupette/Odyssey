using System.Net;
using System.Text.Json.Serialization;

namespace Project.Core;

public class Incident : MapObject
{
    [JsonInclude] private int IncidentID { get; set; }
    [JsonInclude] private IncidentType type { get; set; } //checked by user
    [JsonInclude] private IncidentStatus status { get; set; } //changed automaticly
    [JsonInclude] private IncidentPriority priority { get; set; } //checked by user
    [JsonInclude] private List<EmergencyUnit> unitAssignement = new List<EmergencyUnit>();
    [JsonInclude] private string description { get; set; } = String.Empty; //input by user

    public Incident(IncidentType type, IncidentStatus status, IncidentPriority priority, string description, (int, int) position) : base(position)
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

    public IncidentType getIncidentType()
    {
        return type;
    }

    public IncidentPriority getIncidentPriority()
    {
        return priority;
    }

    public IncidentStatus getIncidentStatus()
    {
        return status;
    }

    public int getIncidentId()
    {
        return IncidentID;
    }
}