using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackTofas : VehicleManager
{
    public VehicleManager vehicleBlackTofas = new VehicleManager();
    void Start()
    {
        vehicleBlackTofas.vehicleId = 0;
        vehicleBlackTofas.vehicleName = "Car";
        vehicleBlackTofas.vehicleSpeed = 140;
    }
}
