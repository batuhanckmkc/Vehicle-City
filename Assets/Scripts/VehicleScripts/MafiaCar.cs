using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MafiaCar : VehicleManager
{
    public VehicleManager vehicleMafia = new VehicleManager();
    void Start()
    {
        vehicleMafia.vehicleId = 3;
        vehicleMafia.vehicleName = "Mafia Car";
        vehicleMafia.vehicleSpeed = 500;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
