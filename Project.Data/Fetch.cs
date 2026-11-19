using System.Text.Json;
using Project.Core;
namespace Project.Data;

class Fetcher
{
    string filename = "incidentData.json";
    public Incident GetIncident(int IncidentID)
    {
        Incident[]? incidents = JsonSerializer.Deserialize<Incident[]>(filename);
        //if (incidents == null) {throw Exception ;}
        foreach (Incident Current in incidents)
        {
            if (Current.GetID == IncidentID) { return Current; }
        }
    }
}