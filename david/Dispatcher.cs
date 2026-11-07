//First testing for dispatcher class

//using which other files

//creating instance
Dispatcher dispatchertest1 = new Dispatcher(1, "Dispatcher 1");
Console.WriteLine(dispatchertest1.name);
Console.WriteLine(dispatchertest1.id);

//Dispatcher class
//Wouldn't there have to be an array to store all the incdients that are registered?
//Also i cant't really do much much i think because there is not a lot to base the class off of


public class Dispatcher
{
    //public int maxIncidentsAtOnce = 10; // NOT NEEDED ANYMORE BECAUSE OF STRING LIST//max incidents at once, could be changed to a variable that is set in the constructor
    //private string[] incidents = new Incident[maxIncidentsAtOnce]; //NOT NEEDED ANYMORE BECAUSE OF STRING LIST 
    private List<Incident> incidents = new List<Incident>(); //array for all the incidents; new variable for max incidents 
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
        incidents.Add(incident); //this is just a test, will have to be changed to a more dynamic way of adding incidents
    }

    public void ViewIncident() //this should have an input something like selectedIncident or something; future
    {
        
    }

    public void SelectIncident(Incident incident)
    {
        this.selectedIncident = incident;
    }

    public void UpdateIncidentStatus(IncidentPriority priority) 
    {
        this.selectedIncident.priority = priority;
    }

    public void UpdatePriorityLevel(IncidentPriority priority) 
    {
        this.selectedIncident.priority = priority;
    }

    public void AssignPriorityLevels(Incident incident, IncidentPriority priority)
    {
        incident.priority = priority;
    }

    public void AllocateUnits(EmergencyUnit unit) //have to work on the algorithm to check the allocated units
    {
        this.selectedIncident.unitAssignement[0] = unit; 
    }

}