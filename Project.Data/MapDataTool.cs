using System.Text.Json;
using Project.Core;
namespace Project.Data;

public class D_MapDataTool
{
    string[] SaveMapFilename = ["mapDefault.json", "save1.json", "save2.json", "save3.json"];

    // TO DO : ONCE MAP CLASS IS DONE, REPLACE "Object" CLASS WITH "Map" CLASS IN THE FOLLOWING AND REREAD JIC
    // Note: Funcs don't validate Map objects, only the ID of the save slot
    public Object GetMapSave(int MapID = 0)
    {
        // Validate MapID and the existence of the default map
        if (MapID < 0 || MapID > 3) { throw new InvalidSaveIDException("LOAD MapID " + MapID + " is out of the valid range <0,3>"); }
        if (!File.Exists(SaveMapFilename[0])) { throw new DefaultMapFileDNEException("Default map file doesn't exist"); }

        string WorkingFilename = SaveMapFilename[MapID];

        // Case for opening a new save
        if (!File.Exists(WorkingFilename)) { WorkingFilename = SaveMapFilename[0]; }

        Object? Map = JsonSerializer.Deserialize<Object>(WorkingFilename);

        // Nullcheck
        if (Map == null) { throw new DefaultMapFileDNEException("Default map file(" + SaveMapFilename[0] + ") is null"); }
        return Map;
    }
    public void SaveMap(Object MapToSave, int MapID)
    {
        // Validate MapID, then save
        if (MapID < 1 || MapID > 3) { throw new InvalidSaveIDException("SAVE MapID " + MapID + " is out of the valid range <1,3>"); }
        File.WriteAllText(SaveMapFilename[MapID], JsonSerializer.Serialize(MapToSave));
    }
}