using System.Text.Json.Serialization;
class EmergencyUnit : MapObject, IgetId
{
    private static int unitIdCounter = 0;
    [JsonInclude] private int unitId;
    [JsonInclude] private EmergencyUnitType type;
    [JsonInclude] private AvailabilityStatus availability;
    [JsonInclude] private int? homeStationId; 
    [JsonInclude] private int? assignedIncidentId; 

    public EmergencyUnit(EmergencyUnitType type, AvailabilityStatus status, int[] position, int? homeStation = null) : base(position)
    {
        this.unitId = unitIdCounter++;
        this.type = type;
        this.homeStationId = homeStation;
        this.availability = status;
    }

    public int getAssignedIncident()
    {
        if (assignedIncidentId == null)
        {
            throw new Exception("No incident assigned to this unit.");
        }
        
        return assignedIncidentId.Value;
    }

    public AvailabilityStatus getAvailability()
    {
        return availability;
    }

    public void setAssignedIncident(Incident incident)
    {
        assignedIncidentId = incident.getId();
    }

    public void setAvailability(AvailabilityStatus newAvailiblitySatus)
    {
        availability = newAvailiblitySatus;
    }



    //id rework stuff
    public int getId()
    {
        return unitId;
    }
}
