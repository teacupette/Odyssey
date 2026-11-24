namespace Project.Core;

public class EmergencyUnit : MapObject
{
    private int EmergencyUnitID;
    private EmergencyUnitType type;

    private Station homeStation;

    private AvailabilityStatus status;

    private Incident? AssignedIncident;

    //methods to be implemented
    public EmergencyUnit(int EmergencyUnitID, EmergencyUnitType type, Station homeStation, AvailabilityStatus status, (int, int) position) : base(position)
    {
        this.EmergencyUnitID = EmergencyUnitID;
        this.type = type;
        this.homeStation = homeStation;
        this.status = status;
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
    public int getUnitId()
    {
        return EmergencyUnitID;
    }
    public void setUnitId(int NewID)
    {
        EmergencyUnitID = NewID;
    }


    public void setAssignedIncident(Incident incident)
    {
        this.AssignedIncident = incident;
    }
}
