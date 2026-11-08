using System.Text.Json.Serialization;
class EmergencyUnit : MapObject
{
    private static int idCounter = 0;
    private static List<EmergencyUnit> allUnits = new List<EmergencyUnit>();
    [JsonInclude] private int unitId;
    [JsonInclude] private EmergencyUnitType type;

    private Station? homeStation; //[JsonInclude]

    [JsonInclude] private AvailabilityStatus status;

    private Incident? AssignedIncident; //[JsonInclude] 

    //methods to be implemented
    public EmergencyUnit(EmergencyUnitType type, Station homeStation, AvailabilityStatus status, int[] position) : base(position)
    {
        this.unitId = idCounter++;
        this.type = type;
        this.homeStation = homeStation;
        this.status = status;
        allUnits.Add(this);
    }

    public Incident getAssignedIncident()
    {
        if (AssignedIncident == null)
        {
            throw new Exception("No incident assigned to this unit.");
        }
        
        return AssignedIncident;
    }

    public AvailabilityStatus GetStatus()
    {
        return status;
    }

    public void setAssignedIncident(Incident incident)
    {
        this.AssignedIncident = incident;
    }



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
