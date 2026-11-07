class Station
{
    private List<EmergencyUnit> assignedUnits= new List<EmergencyUnit>(); 
    private StationType type;
    private int capacity;
    public List<EmergencyUnit> getUnits()
    {
        return assignedUnits;
    }
}