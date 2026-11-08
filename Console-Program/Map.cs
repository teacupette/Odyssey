using System.Text.Json.Serialization;
class Map
{
    private static Map map;
    [JsonInclude] private List<Incident> loadedIncidents {get; set;}
    [JsonInclude] private List<EmergencyUnit> loadedUnits {get; set;}
    [JsonInclude] private List<Station> loadedStations {get; set;}

    public Map()
    {       
        map = this;
        this.loadedIncidents = new List<Incident>();
        this.loadedUnits = new List<EmergencyUnit>();
        this.loadedStations = new List<Station>();
    }

    public void printMapObjects()
    {
        Console.WriteLine("Loaded Incidents:");
        foreach (var incident in loadedIncidents)
        {
            Console.WriteLine($"Incident at position: ({incident.getPosition()[0]}, {incident.getPosition()[1]})");
        }

        Console.WriteLine("\nLoaded Emergency Units:");
        foreach (var unit in loadedUnits)
        {
            Console.WriteLine($"Unit ID: {unit.getId()} at position: ({unit.getPosition()[0]}, {unit.getPosition()[1]})");
        }

        Console.WriteLine("\nLoaded Stations:");
        foreach (var station in loadedStations)
        {
            Console.WriteLine($"Station at position: ({station.getPosition()[0]}, {station.getPosition()[1]})");
        }
    }
    public void loadMapObject(MapObject mapObject)
    {
        if (mapObject is Incident incident)
        {
            loadedIncidents.Add(incident);
        }
        else if (mapObject is EmergencyUnit unit)
        {
            loadedUnits.Add(unit);
        }
        else if (mapObject is Station station)
        {
            loadedStations.Add(station);
        }
    }

    public void unloadMapObject(MapObject mapObject)
    {
        if (mapObject is Incident incident && loadedIncidents.Contains(incident))
        {
            loadedIncidents.Remove(incident);
        }
        else if (mapObject is EmergencyUnit unit && loadedUnits.Contains(unit))
        {
            loadedUnits.Remove(unit);
        }
        else if (mapObject is Station station && loadedStations.Contains(station))
        {
            loadedStations.Remove(station);
        }else
        {
            throw new Exception("MapObject not found in the map.");
        }
    }

    public static Station getStation(int objectId)
    {
        return map.loadedStations[objectId];
    }

    public static Incident getIncident(int objectId)
    {
        return map.loadedIncidents[objectId];
    }
    public static EmergencyUnit getEmergencyUnit(int objectId)
    {
        return map.loadedUnits[objectId];
    }
}