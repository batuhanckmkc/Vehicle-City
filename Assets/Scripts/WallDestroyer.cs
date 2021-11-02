using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestroyer : MonoBehaviour
{
    public VehicleController vehicleController;
    public GameObject floatingCoins;
    public static int wallIndex = 0;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Destroy(other.gameObject);
            Destroy(gameObject);
            wallIndex--;
            Debug.Log("wallIndexXX:" + " " + wallIndex);
            //Instantiate(floatingCoins, transform.position, Quaternion.identity);
        }
        if (other.gameObject.tag == "Tank")
        {
            Destroy(gameObject);
            wallIndex--;
            Instantiate(floatingCoins, transform.position, Quaternion.identity);
            VehicleController.tankCoinCollect = VehicleController.tankCoinCollect + 250;
            Debug.Log(VehicleController.tankCoinCollect);
        }
        if(other.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            wallIndex--;
        }
    }
}
