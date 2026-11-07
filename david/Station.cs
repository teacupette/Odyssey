class Station : MapObject
{
    private List<EmergencyUnit> assignedUnits= new List<EmergencyUnit>(); 
    private StationType type;
    private int capacity;

    public Station(EmergencyUnit[] assignedUnits, StationType type, int capacity, (int, int) position) : base(position)
    {
        this.assignedUnits = assignedUnits;
        this.type = type;
        this.capacity = capacity;


    }
    public List<EmergencyUnit> getUnits()
    {
        return assignedUnits;
    }
}