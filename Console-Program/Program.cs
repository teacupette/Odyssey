using System.Text.Json;


Station station = new Station(new List<int>{}, StationType.FireStation, 10, new int[] { 0, 0 });
Station station2 = new Station(new List<int>{}, StationType.PoliceStation, 5, new int[] { 10, 10 });
station.addUnit(new EmergencyUnit(EmergencyUnitType.Firetruck, AvailabilityStatus.Available, new int[] { 1, 1 }, station2.getId()));
station.addUnit(new EmergencyUnit(EmergencyUnitType.Firetruck, AvailabilityStatus.Available, new int[] { 123, 3 }));

Map map = new Map();
map.loadMapObject(station);
map.loadMapObject(station2);
map.loadMapObject(new EmergencyUnit(EmergencyUnitType.Ambulance, AvailabilityStatus.Available, new int[] { 5, 5 }, station.getId()));
map.loadMapObject(new EmergencyUnit(EmergencyUnitType.Ambulance, AvailabilityStatus.Available, new int[] { 6, 6 }, station.getId()));
map.loadMapObject(new EmergencyUnit(EmergencyUnitType.Ambulance, AvailabilityStatus.Available, new int[] { 7, 7 }, station2.getId()));
map.loadMapObject(new Incident(IncidentType.Fire, IncidentStatus.Active, IncidentPriority.High, "Fire at 123 Main St", new int[] { 2, 2 }));
map.loadMapObject(new Incident(IncidentType.Medical, IncidentStatus.Active, IncidentPriority.Medium, "Medical emergency at 456 Elm St", new int[] { 3, 3 }));
map.loadMapObject(new Incident(IncidentType.Police, IncidentStatus.Active, IncidentPriority.Low, "Burglary at 789 Oak St", new int[] { 4, 4 }));

string JsonString = JsonSerializer.Serialize(map, new JsonSerializerOptions { WriteIndented = true });
Console.WriteLine(JsonString);

map.printMapObjects();

Map map2 = JsonSerializer.Deserialize<Map>(JsonString)!;
map2.printMapObjects();

/*
string jsonString = File.ReadAllText("../../../Json/Map.Json");
Map map = JsonSerializer.Deserialize<Map>(jsonString)!;
map.printMapObjects();
*/


string line;
while((line = Console.ReadLine()) != "stop")
{
    Console.WriteLine("Starting");
}