using System.Text.Json;
using Project.Core;
namespace Project.Data;

public class D_MapDataTool
{
    string[] SaveMapFilename = ["mapDefault.json", "save1.json", "save2.json", "save3.json"];

    // TO DO : ONCE MAP CLASS IS DONE, REPLACE "Object" CLASS WITH "Map" CLASS IN THE FOLLOWING AND REREAD JIC
    public Object GetMapSave(int MapID = 0)
    {
        if (MapID < 0 || MapID > 3) { throw new InvalidSaveIDException("LOAD MapID " + MapID + " is out of the valid range <0,3>"); }
        if (!File.Exists(SaveMapFilename[0])) { throw new DefaultMapFileDNEException("Default map file doesn't exist"); }
        string WorkingFilename = SaveMapFilename[MapID];
        if (!File.Exists(WorkingFilename)) { WorkingFilename = SaveMapFilename[0]; }
        Object? Map = JsonSerializer.Deserialize<Object>(WorkingFilename);
        if (Map == null) { throw new DefaultMapFileDNEException("Default map file(" + SaveMapFilename[0] + ") is null"); }
        return Map;
    }
    public void SaveMap(Object MapToSave, int MapID)
    {
        if (MapID < 1 || MapID > 3) { throw new InvalidSaveIDException("SAVE MapID " + MapID + " is out of the valid range <1,3>"); }
        File.WriteAllText(SaveMapFilename[MapID], JsonSerializer.Serialize(MapToSave));
    }
}