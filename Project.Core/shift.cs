namespace Project.Core;

public class Shift
{
    private int shiftTime;
    private List<Incident> completedIncident;
    private int timeToFinish;
    private int amountUnits; //Amount of units used in the shift
    /*
    public string getData() //End-of-shift report
    {
        return completedIncidents().ToString();
        //TODO
        //Amount of incidents completed 
        //Avg. time it took per. incident -> Add a way to calculate the avg. time
        //Time spent in total in shift
        //Amount of units used in the shift (and what kind of units)
    }
    */
    /*
    public List<Incident> completedIncidents()
    {
        foreach (Incident i in dispatcher.showIncident)
        {
            if (i.IncidentStatus == Completed)
            {
                completedIncident.Add(i);
            }
        }
        return completedIncident;
    }*/
}
