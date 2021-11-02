using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vosvos : VehicleManager
{
    public VehicleManager vehicleVosVos = new VehicleManager();
    void Start()
    {
        
        vehicleVosVos.vehicleId = 1;
        vehicleVosVos.vehicleName = "Vosvos";
        vehicleVosVos.vehicleSpeed = 140;
    }
}
