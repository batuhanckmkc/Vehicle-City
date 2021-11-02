using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : VehicleManager
{
    public VehicleManager vehicleTank = new VehicleManager();
    void Start()
    { 
        vehicleTank.vehicleId = 3;
        vehicleTank.vehicleName = "Tank";
        vehicleTank.vehicleSpeed = 150;
    }
}
