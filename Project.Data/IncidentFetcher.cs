using System.Text.Json;
using Project.Core;
namespace Project.Data;

public class D_IncidentFetcher
{
    // ------------------------------------------------------------------------
    // The D_IncidentFetcher class serves to return Incident objects by their IncidentID (which is stored in the .json)
    // Note: If multiple Incident objects have the same ID, the one that is first in the .json will be returned
    // ------------------------------------------------------------------------
    string filename = "incidentData.json";
    public Incident GetIncident(int IncidentID)
    {
        if (!File.Exists(filename)) { throw new NullIncidentJsonException(filename + " doesn't exist"); }

        Incident[]? incidents = JsonSerializer.Deserialize<Incident[]>(filename);

        if (incidents == null) { throw new NullIncidentJsonException(filename + " is null and was referenced"); }

        foreach (Incident Current in incidents)
        {
            if (Current.getIncidentId() == IncidentID) { return Current; }
        }
        throw new InvalidIncidentIdReferenceException(filename + " doesn't contain an Incident with the requested ID");
    }
}