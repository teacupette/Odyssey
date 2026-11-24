using System.Text.Json;
using Project.Core;
namespace Project.Data;

public class D_MapDataTool
{
    // ------------------------------------------------------------------------
    // The MapDataTool serves to save and return Map objects to/from their respective json files
    // Note: MapIDs are checked for validity, however Map objects are only nullchecked 
    // TO DO : ONCE MAP CLASS IS DONE, REPLACE "Object" CLASS WITH "Map" CLASS IN THE FOLLOWING AND REREAD JIC
    // ------------------------------------------------------------------------
    string[] SaveMapFilename = ["mapDefault.json", "mapSave_A.json", "mapSave_B.json", "mapSave_C.json"];
    int MaxNumberOfSaves = 3;
    
    public Object GetMapSave(int MapID = 0)
    {
        // Validate MapID and the existence of the default map
        if (MapID < 0 || MapID > MaxNumberOfSaves) { throw new InvalidIDException("LOAD MapID " + MapID + " is out of the valid range <0," +  MaxNumberOfSaves + ">"); }
        if (!File.Exists(SaveMapFilename[0])) { throw new JsonDNEException("Default map file doesn't exist"); }

        string WorkingFilename = SaveMapFilename[MapID];

        // Case for opening a new save
        if (!File.Exists(WorkingFilename)) { WorkingFilename = SaveMapFilename[0]; }

        Object? Map = JsonSerializer.Deserialize<Object>(WorkingFilename);
    
        if (Map == null) { throw new NullJsonException("Default map file(" + SaveMapFilename[0] + ") is null"); }
        return Map;
    }
    public void SaveMap(Object MapToSave, int MapID)
    {
        // Validate MapID, then save
        if (MapID < 1 || MapID > MaxNumberOfSaves) { throw new InvalidIDException("SAVE MapID " + MapID + " is out of the valid range <1," + MaxNumberOfSaves + ">"); }
        File.WriteAllText(SaveMapFilename[MapID], JsonSerializer.Serialize(MapToSave));
    }
}