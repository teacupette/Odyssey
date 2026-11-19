using System.Text.Json;
using Project.Core;
namespace Project.Data;

class D_IncidentFetcher
{
    string filename = "incidentData.json";
    public Incident GetIncident(int IncidentID)
    {
        Incident[]? incidents = JsonSerializer.Deserialize<Incident[]>(filename);
        if (incidents == null) { throw new NullIncidentJsonException(filename + " is null and was referenced"); }
        foreach (Incident Current in incidents)
        {
            if (Current.getIncidentId() == IncidentID) { return Current; }
        }
        throw new InvalidIncidentIdReferenceException(filename + " doesn't contain an Incident with the requested ID");
    }
}