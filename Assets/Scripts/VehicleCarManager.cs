using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleCarManager : VehicleManager
{
    public VehicleManager vehicleTofas = new VehicleManager();
    public VehicleManager vehicleVosVos = new VehicleManager();
    public VehicleManager vehicleBroadway = new VehicleManager();
    public VehicleManager vehicleMafia = new VehicleManager();
    public VehicleManager vehicleTank = new VehicleManager();
    public VehicleManager vehicleBlackTofas = new VehicleManager();
    void Start()
    {
        vehicleVosVos.vehicleId = 0;
        vehicleVosVos.vehicleName = "Vosvos";
        vehicleVosVos.vehicleSpeed = 100;

        vehicleTofas.vehicleId = 1;
        vehicleTofas.vehicleName = "White Tofask";
        vehicleTofas.vehicleSpeed = 120;

        vehicleBlackTofas.vehicleId = 2;
        vehicleBlackTofas.vehicleName = "Black Tofask";
        vehicleBlackTofas.vehicleSpeed = 140;

        vehicleBroadway.vehicleId = 3;
        vehicleBroadway.vehicleName = "Broadway";
        vehicleBroadway.vehicleSpeed = 250;

        vehicleTank.vehicleId = 4;
        vehicleTank.vehicleName = "Tank";
        vehicleTank.vehicleSpeed = 150;

        vehicleMafia.vehicleId = 5;
        vehicleMafia.vehicleName = "Mafia Car";
        vehicleMafia.vehicleSpeed = 500;
    }   
}
