using System.Text.Json;


Console.WriteLine("Hello");
Station station = new Station(new List<int>{}, StationType.FireStation, 10, new int[] { 0, 0 });
Station station2 = new Station(new List<int>{}, StationType.PoliceStation, 5, new int[] { 10, 10 });
station.addUnit(new EmergencyUnit(EmergencyUnitType.Firetruck, station2, AvailabilityStatus.Available, new int[] { 1, 1 }));
station.addUnit(new EmergencyUnit(EmergencyUnitType.Firetruck, station2, AvailabilityStatus.Available, new int[] { 123, 3 }));


string JsonString = JsonSerializer.Serialize(station, new JsonSerializerOptions { WriteIndented = true });
Console.WriteLine(JsonString);



string line;
while((line = Console.ReadLine()) != "stop")
{
    Console.WriteLine("Starting");
}