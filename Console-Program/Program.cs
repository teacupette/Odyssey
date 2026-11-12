using System.Collections;

Console.WriteLine("Hello");
Console.WriteLine("\nStart? PRESS ENTER TO START");
string line;


Dispatcher dispatcher = new Dispatcher(1, "Test");
EmergencyUnit policecar1 = new EmergencyUnit(EmergencyUnitType.PoliceCar, StationType.PoliceStation, AvailabilityStatus.Available,(0,0));

Station station1 = new Station(new List<EmergencyUnit> {policecar1}, StationType.PoliceStation, 3, (0,0));
Incident incident1 = new Incident(IncidentType.Police, IncidentStatus.Active, IncidentPriority.Low, description:"",(1,0) );


while((line = Console.ReadLine()) != "stop")
{
    Console.WriteLine("Starting");
    System.Threading.Thread.Sleep(2000);
    Console.WriteLine("\nYou are a Dispatcher. Look a call");
    
    Console.WriteLine("Ring...");
    Console.WriteLine("Ring...Ring...");
    Console.WriteLine("Ring...Ring...Ring...");
    //Something Text

    Console.WriteLine("What is the Type if the Incident?");
    Console.WriteLine("1. Fire");
    Console.WriteLine("2. FireLadder");
    Console.WriteLine("3. FireTraffic");
    Console.WriteLine("4. Police");
    Console.WriteLine("5. Medical");

    switch (Console.ReadLine())
    {
        case ("1"):
            break;
        
        case ("2"):
            break;

        case ("3"):
            break;
        
        case ("4"):
            break;
        
        case ("5"):
            break;
    }

    

} 



//Console.WriteLine("Test");

