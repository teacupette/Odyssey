using System.Text.Json;
using System.Text.Json.Serialization;
class DispatcherSimulation
{
    [JsonInclude] private Map map;
    [JsonInclude] private Dispatcher dispatcher;
    [JsonInclude] private Shift shift;
    public DispatcherSimulation(String? SimulationStartStatePath = null)
    {
        if (SimulationStartStatePath != null)
        {
            loadSimulationState(SimulationStartStatePath);
            return;
        }

        map = new Map();
        dispatcher = new Dispatcher(1, "John Doe");
        shift = new Shift(0, 0, 0, 0);
        
    }
    


    public void loadSimulationState(String path)
    {
        if (!File.Exists(path))
        {
            throw new FileNotFoundException($"The file at path {path} does not exist.");
        }
        map = JsonSerializer.Deserialize<Map>(path)!;
        dispatcher = JsonSerializer.Deserialize<Dispatcher>(path)!;
        shift = JsonSerializer.Deserialize<Shift>(path)!;
    }
    public void saveSimulationState(String path)
    {
        File.Create(path);
        string jsonString = JsonSerializer.Serialize(map);
        File.WriteAllText(path, jsonString);
    }

    public void loadSimulationObjectToMap(String path, String objectType)
    {
        if (!File.Exists(path))
        {
            throw new FileNotFoundException($"The file at path {path} does not exist.");
        }
        
        switch (objectType)
        {
            case "Incident":
                Incident incident = JsonSerializer.Deserialize<Incident>(path)!;
                map.LoadMapObject(incident);
                break;
            case "Station":
                Station station = JsonSerializer.Deserialize<Station>(path)!;
                map.LoadMapObject(station);
                break;
            case "EmergencyUnit":
                EmergencyUnit unit = JsonSerializer.Deserialize<EmergencyUnit>(path)!;
                map.LoadMapObject(unit);
                break;
            default:
                throw new ArgumentException($"Invalid object type: {objectType}. Must be 'Incident', 'Station', or 'EmergencyUnit'.");
        }
    }
}