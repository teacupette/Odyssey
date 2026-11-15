


Console.WriteLine("Hello");
Console.WriteLine("\nStart? PRESS ENTER TO START");
string? line;



Dispatcher dispatcher = new Dispatcher(1, "Test");
//EmergencyUnit policecar1 = new EmergencyUnit(EmergencyUnitType.PoliceCar, StationType.PoliceStation, AvailabilityStatus.Available,(0,0));

//Station station1 = new Station(new List<EmergencyUnit> {policecar1}, StationType.PoliceStation, 3, (0,0));
Incident incident1 = new Incident(IncidentType.Police, IncidentStatus.Active, IncidentPriority.Low, description: "", (1, 0));
string incident1text = "Incoming Call:\n\nOperator: 112, whats Emergency\nCallerOperator: “112, what’s your emergency?\nCaller: My shop’s fire alarm has gone off. The address is Perlegade 67.\nOperator: What’s your phone number, in case we get cut off?\nOperator: Are you at the shop now, or is anyone there?\nCaller: “No, I’m at home, far away. I just got an alarm notification on my phone.\nOperator: “Do you know of any smoke, fire, or smell, or has anyone nearby reported anything?\nCaller: No, I only know the alarm has been triggered.\nperator: Is the building more than one floor, and is it connected to other buildings or homes?\nCaller: No, only ground floor, and it stands alone.\nOperator: What’s the name of the shop, and your name?\nCaller: Alberts Bageri. Albert Mikkelsen. \nOperator: Is there anything dangerous inside, like gas, ovens that might be on, or other hazards?\nCaller: There are gas ovens, but they should be off at night.\nOperator: Has this alarm gone off falsely before? \nCaller: No, definitely not.\nOperator: Can the fire service access the building, or does someone need to bring a key?\nCaller: There’s a key box by the front door. I can also drive over.\nOperator: Please don’t go inside if you arrive before us. Wait outside and stay reachable on this number. We are sending help now.";


while((line = Console.ReadLine()) != "stop")
{
    
    Console.WriteLine("Hi Dispathcer. What Do you want to do?");
    Console.WriteLine("1.IncidentCall\n2.Stop the programm");
    switch (Console.ReadLine())
    {
        case"1":
            {
                dispatcher.RegisterNewIncident(incident1);
                Console.WriteLine("First Incident Ready!");
                break;
            }

        case"2":
            {
                Environment.Exit(0);
                break;
            }
        default:
            {
                break;
            }
    }
    Console.WriteLine(incident1text);
    while (inIncident==True)
    {
        Console.WriteLine("1.EmergencyType\n2.IncidentPriority\n3.Exit Incident\n4.Stop the program");
        switch (Console.ReadLine)
        {
        case "1":
            {
                Console.WriteLine("Whats the Emergencytype?\n1.Police\n2.Fire\n3.Medical"); //This is the idea it dosn't work yet.
                switch (Console.ReadLine)
                {
                    case"1":
                        {
                            incident1.IncidentType.set(Police);
                            break;
                        }
                    
                    case"2":
                        {
                            incident1.IncidentType.set(Fire);
                            break;
                        }
                    
                    case"3":
                        {
                            incident1.IncidentType.set(Medical);
                        }
                }
                break;
            }
        }
    
    }
    
    

} 





