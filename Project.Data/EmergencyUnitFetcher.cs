using System.Text.Json;
using Project.Core;
namespace Project.Data;

public class D_EmergencyUnitFetcher
{
    // ------------------------------------------------------------------------
    // The D_EmergencyUnitFetcher class serves to return EmergencyUnit objects by their EmergencyUnitID (which is stored in the .json)
    // Note: If multiple EmergencyUnit objects have the same ID, the one that is first in the .json will be returned
    // ------------------------------------------------------------------------
    string filename = "emergencyUnitData.json";
    public EmergencyUnit GetEmergencyUnit(int EmergencyUnitID)
    {
        if (!File.Exists(filename)) { throw new JsonDNEException(filename + " doesn't exist"); }

        EmergencyUnit[]? emergencyUnits = JsonSerializer.Deserialize<EmergencyUnit[]>(filename);

        if (emergencyUnits == null) { throw new NullJsonException(filename + " is null and was referenced"); }

        foreach (EmergencyUnit Current in emergencyUnits)
        {
            if (Current.getUnitId() == EmergencyUnitID) { return Current; }
        }
        throw new InvalidIDException(filename + " doesn't contain an Incident with the requested ID");
    }
}