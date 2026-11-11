Console.WriteLine("Hello");
Console.WriteLine("\nStart? PRESS ENTER TO START");
string line;


Dispatcher dispatcher = new Dispatcher(1, "Test");
Station station1 = new Station(assignedUnits:policecar1, StationType.PoliceStation, 3, (0,0));
EmergencyUnit policecar1 = new EmergencyUnit(EmergencyUnitType.PoliceCar, StationType.PoliceStation, AvailabilityStatus.Available,(0,0));
Incident incident1 = new Incident(IncidentType.Police, IncidentStatus.Active, IncidentPriority.Low, description:"",(1,0) );
/*
while((line = Console.ReadLine()) != "stop")
{
    Console.WriteLine("Starting");
    System.Threading.Thread.Sleep(2000);


    Console.WriteLine("\nYou are a Dispatcher. Look a call");
    
} */



//Console.WriteLine("Test");

