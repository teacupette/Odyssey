using System.Text.Json.Serialization;

class Shift
{
    [JsonInclude] private int shiftTime {get; set;}
    [JsonInclude] private int completedIncidents {get; set;}
    [JsonInclude] private int timeToFinish {get; set;}
    [JsonInclude] private int amountUnits {get; set;}
    public string getData()
    {
        return $"Shift Time: {shiftTime}, Completed Incidents: {completedIncidents}, Time to Finish: {timeToFinish}, Amount of Units: {amountUnits}";
    }

    public Shift(int shiftTime, int completedIncidents, int timeToFinish, int amountUnits)
    {
        this.shiftTime = shiftTime;
        this.completedIncidents = completedIncidents;
        this.timeToFinish = timeToFinish;
        this.amountUnits = amountUnits;
    }
}