using System;

namespace david;

public class EmergencyUnit
{

    EmergencyUnitType type = new EmergencyUnitType();

    StationType homeStation = new StationType();

    AvailabilityStatus status = new AvailabilityStatus();

    Incident AssignedIncident = new Incident();

    //methods to be implemented

    public Incident getAssignedIncident();

    public AvailabilityStatus GetStatus();


    public void setAssignedUnit();









}
