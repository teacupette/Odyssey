using System.Text.Json.Serialization;
class Map
{
    [JsonInclude] private List<Incident> LoadedIncidents;
    [JsonInclude] private List<EmergencyUnit> LoadedUnits;
    [JsonInclude] private List<Station> LoadedStations;

    public Map()
    {       
        this.LoadedIncidents = new List<Incident>();
        this.LoadedUnits = new List<EmergencyUnit>();
        this.LoadedStations = new List<Station>();
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