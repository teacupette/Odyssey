namespace Project.Core;

public enum AvailabilityStatus
{
    Available,
    OnRoute,
    OnScene,
    Returning
}
public enum EmergencyUnitType
{
    Firetruck,
    FiretruckLadder,
    FiretruckTraffic,
    PoliceCar,
    Ambulance
}
public enum IncidentPriority
{
    Low,
    Medium,
    High
}
public enum IncidentStatus

{
    Incoming,
    Active,
    Completed
}

public enum IncidentType
{
    Fire,
    Police,
    Medical,
    FireTraffic,
    FireLadder

}
public enum StationType
{
    FireStation,
    PoliceStation,
    Hospital
}