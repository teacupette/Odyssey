class EmergencyUnit
{

    private EmergencyUnitType type;

    private StationType homeStation;

    private AvailabilityStatus status;

    private Incident AssignedIncident;

    //methods to be implemented
    public EmergencyUnit(EmergencyUnitType type, StationType homeStation, AvailabilityStatus status)
    {
        this.type = type;
        this.homeStation = homeStation;
        this.status = status;
    }

    public Incident getAssignedIncident()
    {
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









}
