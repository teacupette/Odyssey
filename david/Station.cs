class Station : MapObject
{
    private EmergencyUnit[] assignedUnits;
    private StationType type;
    private int capacity;

    public Station(EmergencyUnit[] assignedUnits, StationType type, int capacity, (int, int) position) : base(position)
    {
        this.assignedUnits = assignedUnits;
        this.type = type;
        this.capacity = capacity;


    }
    public EmergencyUnit[] getUnits()
    {
        return assignedUnits;
    }
}