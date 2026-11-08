using System.Text.Json.Serialization;
class DispatcherSimulation
{
    [JsonInclude] private Map map;
    [JsonInclude] private Dispatcher dispatcher;
    [JsonInclude] private Shift shift;
    public DispatcherSimulation(String SimulationStartStatePath)
    {
        LoadSimulationState(SimulationStartStatePath);
    }
    
    public void LoadSimulationState(String path)
    {
        this.map = new Map();
        this.dispatcher = new Dispatcher(1, "John Doe");
        //this.shift = new Shift();
    }


}