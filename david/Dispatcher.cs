//First testing for dispathcer class

//using which other files

//creating instance
Dispatcher dispatchertest1 = new Dispatcher(1, "Dispathcer 1");
Console.WriteLine(dispatchertest1.name);
Console.WriteLine(dispatchertest1.id);

//Dispatcher class
//Wouldn't there have to be an array to store all the incdients that are registered?
//Also i cant't really do much much i think because there is not a lot to base the class off of


public class Dispatcher
{
    public int maxIncidentsAtOnce = 10; //max incidents at once, could be changed to a variable that is set in the constructor
    private string[] incidents = new Incident[maxIncidentsAtOnce]; //array for all the incidents; new variable for max incidents 
    //at once which could originate in the incident class itself
    private int id{get; set;}
    private string name{get; set;}
    private Incident selectedIncident;
    Dispatcher(int id, string name)
    {
        this.id = id;
        this.name = name;
    }

    public void RegisterNewIncident(Incident incident)
    {
        incidents[0] = incident; //this is just a test, will have to be changed to a more dynamic way of adding incidents
    }

    public void ViewIncident() //this should have an input something like selectedIncident or something
    {
        
    }

    public void SelectIncident(Incident incident)
    {
        
    }

    public void UpdateIncident() //this should have an input and/or be repetetive? Incident status
    {
        
    }

    public void AssignPriorityLevels()
    {
        incident.priority = IncidentPriority;
    }

    public void AllocateUnits(EmergencyUnit unit) //have to work on the algorithm to check the allocated units
    {
        incident.unitAssignement[0] = unit; 
    }

}