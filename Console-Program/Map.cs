using System.Text.Json.Serialization;
class Map
{
    [JsonInclude] private List<Incident> LoadedIncidents {get; set;}
    [JsonInclude] private List<EmergencyUnit> LoadedUnits {get; set;}
    [JsonInclude] private List<Station> LoadedStations {get; set;}

    public Map()
    {       
        this.LoadedIncidents = new List<Incident>();
        this.LoadedUnits = new List<EmergencyUnit>();
        this.LoadedStations = new List<Station>();
    }

    public void printMapObjects()
    {
        Console.WriteLine("Loaded Incidents:");
        foreach (var incident in LoadedIncidents)
        {
            Console.WriteLine($"Incident at position: ({incident.getPosition()[0]}, {incident.getPosition()[1]})");
        }

        Console.WriteLine("\nLoaded Emergency Units:");
        foreach (var unit in LoadedUnits)
        {
            Console.WriteLine($"Unit ID: {unit.getId()} at position: ({unit.getPosition()[0]}, {unit.getPosition()[1]})");
        }

        Console.WriteLine("\nLoaded Stations:");
        foreach (var station in LoadedStations)
        {
            Console.WriteLine($"Station at position: ({station.getPosition()[0]}, {station.getPosition()[1]})");
        }
    }
    public void LoadMapObject(MapObject mapObject)
    {
        if (mapObject is Incident incident)
        {
            LoadedIncidents.Add(incident);
        }
        else if (mapObject is EmergencyUnit unit)
        {
            LoadedUnits.Add(unit);
        }
        else if (mapObject is Station station)
        {
            LoadedStations.Add(station);
        }
    }

    public void UnloadMapObject(MapObject mapObject)
    {
        if (mapObject is Incident incident && LoadedIncidents.Contains(incident))
        {
            LoadedIncidents.Remove(incident);
        }
        else if (mapObject is EmergencyUnit unit && LoadedUnits.Contains(unit))
        {
            LoadedUnits.Remove(unit);
        }
        else if (mapObject is Station station && LoadedStations.Contains(station))
        {
            LoadedStations.Remove(station);
        }else
        {
            throw new Exception("MapObject not found in the map.");
        }
    }

}