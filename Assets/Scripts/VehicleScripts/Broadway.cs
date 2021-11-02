using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broadway : VehicleManager
{
    public VehicleManager vehicleBroadway = new VehicleManager();
    void Start()
    {
        vehicleBroadway.vehicleId = 2;
        vehicleBroadway.vehicleName = "Broadway";
        vehicleBroadway.vehicleSpeed = 250;
    }
}
