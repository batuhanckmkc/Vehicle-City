using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceCar : VehicleManager
{
    public VehicleManager vehiclePolice = new VehicleManager();

    [SerializeField] Light redLight;
    [SerializeField] Light blueLight;

    private Vector3 redTemp;
    private Vector3 blueTemp;

    [SerializeField] int speed;
    void Start()
    {
        vehiclePolice.vehicleId = 4;
        vehiclePolice.vehicleName = "Police Car";
        vehiclePolice.vehicleSpeed = 300;
    }

    private void Update()
    {
        redTemp.y += speed * Time.deltaTime;
        blueTemp.y -= speed * Time.deltaTime;

        redLight.transform.eulerAngles = redTemp;
        blueLight.transform.eulerAngles = blueTemp;
    }
}
