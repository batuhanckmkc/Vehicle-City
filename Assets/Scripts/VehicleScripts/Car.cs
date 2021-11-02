using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : VehicleManager
{
    public VehicleManager vehicleTofas = new VehicleManager();
    void Start()
    {

        vehicleTofas.vehicleId = 0;
        vehicleTofas.vehicleName = "Car";
        vehicleTofas.vehicleSpeed = 120;
    }
}
