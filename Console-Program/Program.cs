using Project.Core;
using static System.Math;
using static System.Random;


//either the programm checks if something is correct or it just set the attributes with the values choosen by the player


using System.Dynamic;
using System.Net.NetworkInformation;

Console.WriteLine("Start? PRESS ENTER TO START");
//c string? line;

//Random Class Objekt
Random randomiser = new Random();

//Incident Data Class
D_IncidentFetcher incident = new D_IncidentFetcher();

Dispatcher dispatcher = new Dispatcher(1, "Test");
//EmergencyUnit policecar1 = new EmergencyUnit(EmergencyUnitType.PoliceCar, StationType.PoliceStation, AvailabilityStatus.Available,(0,0));

//Station station1 = new Station(new List<EmergencyUnit> {policecar1}, StationType.PoliceStation, 3, (0,0));
Incident incident1 = new Incident(IncidentType.Police, IncidentStatus.Active, IncidentPriority.Low, description: "" , (1, 0));
Incident incident2 = new Incident(IncidentType.Fire, IncidentStatus.Active, IncidentPriority.High, description: "", (1,4));
Incident incident3 = new Incident(IncidentType.Medical, IncidentStatus.Active, IncidentPriority.Medium, description: "", (3,2));


dispatcher.RegisterNewIncident(incident1);
dispatcher.RegisterNewIncident(incident2);
dispatcher.RegisterNewIncident(incident3);
//string incident1text = "Incoming Call:\n\nOperator: 112, whats Emergency\nCallerOperator: “112, what’s your emergency?\nCaller: My shop’s fire alarm has gone off. The address is Perlegade 67.\nOperator: What’s your phone number, in case we get cut off?\nOperator: Are you at the shop now, or is anyone there?\nCaller: “No, I’m at home, far away. I just got an alarm notification on my phone.\nOperator: “Do you know of any smoke, fire, or smell, or has anyone nearby reported anything?\nCaller: No, I only know the alarm has been triggered.\nperator: Is the building more than one floor, and is it connected to other buildings or homes?\nCaller: No, only ground floor, and it stands alone.\nOperator: What’s the name of the shop, and your name?\nCaller: Alberts Bageri. Albert Mikkelsen. \nOperator: Is there anything dangerous inside, like gas, ovens that might be on, or other hazards?\nCaller: There are gas ovens, but they should be off at night.\nOperator: Has this alarm gone off falsely before? \nCaller: No, definitely not.\nOperator: Can the fire service access the building, or does someone need to bring a key?\nCaller: There’s a key box by the front door. I can also drive over.\nOperator: Please don’t go inside if you arrive before us. Wait outside and stay reachable on this number. We are sending help now.";



//----------
bool testing = false; //testing purpose
while(testing ==false)
{
    

    //--------------------------------------------------------
    Console.WriteLine("Hi Dispathcer. What Do you want to do?");
    GameLoop();
} 




void GameLoop()
{   
    

    Console.WriteLine("1.New/Next Incident\n2.IncidentList\n3.Stop the programm\n4.See Stats (I.P.)");
    switch (Console.ReadLine())
    {
        case"1":
            {
                bool inIncident = true;
                int random_id = randomiser.Next(1,11);
                while (inIncident==true)
                {   
                    Console.WriteLine("1.EmergencyType\n2.IncidentPriority\n3.Add Description \n4.Exit Incident\n-----------------------\n5.|Write stop to stop the program|");
                    switch (Console.ReadLine())
                    {
                        case "1":
                    {
                        Console.WriteLine("Whats the Emergencytype?\n1.Police\n2.Fire\n3.Medical"); //checking if the correct type is choosen
                        IncidentType x = GetIncident.getIncidentType(); //This is specificed for 1 objekt
                        if (Console.ReadLine()=="1")
                            if (IncidentType.Police == x)
                                Console.WriteLine("Correct Type Choosen");
                        if (Console.ReadLine()=="2")
                            if (IncidentType.Fire == x)
                                Console.WriteLine("Correct Type Choosen");
                        if (Console.ReadLine()=="3")
                            if (IncidentType.Medical == x)
                                Console.WriteLine("Correct Type Choosen");
                        break;
                    }
                        case "2":
                    {
                        //IncidentPriority
                        Console.WriteLine("Whats the IncidentPriority?\n1.Low\n2.Medium\n3.High"); //checking if the correct type is choosen
                        IncidentPriority x = incident1.getIncidentPriority(); //This is specificed for 1 objekt
                        if (Console.ReadLine()=="1")
                            if (IncidentPriority.Low== x)
                                Console.WriteLine("Correct Priority Choosen");
                        if (Console.ReadLine()=="2")
                            if (IncidentPriority.Medium == x)
                                Console.WriteLine("Correct Priority Choosen");
                        if (Console.ReadLine()=="3")
                            if (IncidentPriority.High == x)
                                Console.WriteLine("Correct Priority Choosen");
                        break;
                        

                    }
                        case "3":
                    {
                        Console.WriteLine("Now add a short description of the emergency with the base information!");
                        //incident1.IncidentDescription(Console.ReadLine());
                        //Add Description
                        break;
                    }
                        case "4":
                    {
                        //Exit Incident
                        inIncident = false;

                        break;
                        
                    }

                        case "stop":
                            {
                                Environment.Exit(0);
                                break;
                            }

                        default:
                    {
                        break;
                    }
                    }
                }
                break;
            }
        case"2"://Finished
            {
                int a = 1;
                foreach (Incident incident in dispatcher.showIncident)
                {
                    Console.WriteLine("\nIncident: " + a + "\nIncidentType: " + incident.getIncidentType()+"\nIncidentStatus: " + incident.getIncidentStatus() + "\nIncidentPriority: " + incident.getIncidentPriority() );
                    a++;
                }
                
                break;
            }
        case"3"://Finished
            {
                Environment.Exit(0);
                break;
            }
        case"4":
            {
                //I.P.
                break;
            }
        default:
            {
                break;
            }
    }
    //Console.WriteLine(incident1text); //this has to be its own thing
    
    
    
}

