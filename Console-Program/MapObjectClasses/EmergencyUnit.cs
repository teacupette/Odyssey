using System.Text.Json.Serialization;
class EmergencyUnit : MapObject, IgetId
{
    private static int idCounter = 0;
    private static List<EmergencyUnit> allUnits = new List<EmergencyUnit>();
    [JsonInclude] private int unitId;
    [JsonInclude] private EmergencyUnitType type;

    [JsonInclude] private int? homeStationId; //[JsonInclude]

    [JsonInclude] private AvailabilityStatus status;

    [JsonInclude] private int? AssignedIncidentId; //[JsonInclude] 

    //methods to be implemented
    public EmergencyUnit(EmergencyUnitType type, AvailabilityStatus status, int[] position, int? homeStation = null) : base(position)
    {
        this.unitId = idCounter++;
        this.type = type;
        this.homeStationId = homeStation;
        this.status = status;
        allUnits.Add(this);
    }
/*
    public Incident getAssignedIncident()
    {
        if (AssignedIncident == null)
        {
            throw new Exception("No incident assigned to this unit.");
        }
        
        return AssignedIncident;
    }*/

    public AvailabilityStatus GetStatus()
    {
        return status;
    }
/*
    public void setAssignedIncident(Incident incident)
    {
        this.AssignedIncident = incident;
    }

*/

    //id rework stuff
    public int getId()
    {
        return unitId;
    }
    public static EmergencyUnit getUnitById(int id)
    {
        foreach (EmergencyUnit unit in allUnits)
        {
            if (unit.getId() == id)
            {
                return unit;
            }
        }
        throw new Exception("No unit found with the given ID.");
    }
}
