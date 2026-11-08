using System.Dynamic;
using System.Text.Json.Serialization;
class Station : MapObject, IgetId
{
    private static int stationIdCounter = 0;
    [JsonInclude] private int stationId{get; set;}
    [JsonInclude] private List<int> assignedUnits= new List<int>(); 
    [JsonInclude] private StationType type;
    [JsonInclude] private int capacity;

    public Station(List<int> assignedUnits, StationType type, int capacity, int[] position) : base(position)
    {
        this.stationId = stationIdCounter++;
        this.assignedUnits = assignedUnits;
        this.type = type;
        this.capacity = capacity;
    }
    public List<int> getUnits()
    {
        return assignedUnits;
    }
    public void addUnit(EmergencyUnit unit)
    {
        if (assignedUnits.Count < capacity)
        {
            assignedUnits.Add(unit.getId());
        }
        else
        {
            throw new Exception("Station is at full capacity.");
        }
    }

    public int getId()
    {
        return stationId;
    }
}