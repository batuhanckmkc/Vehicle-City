using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    /*[SerializeField]
    GameObject vehicleObject;
    Vector3 distance;*/

    public Transform cam, vehicle,shopPlace;
    Vector3 vector;
    public Vector3 distance;
    // Start is called before the first frame update
    void Start()
    {
        //distance = transform.position - vehicleObject.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*transform.position = vehicleObject.transform.position + distance;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, distance, 0.1f);
        transform.position = smoothPosition;*/ 
        if(UIManager.isOnShop == true)
        {
            cam.position = Vector3.Lerp(cam.position, shopPlace.position - distance, 0.15f);
            cam.LookAt(shopPlace);
        }
        else
        {
            cam.position = Vector3.Lerp(cam.position, vehicle.position - distance, 0.15f);
            cam.LookAt(vehicle);
        }
    }
}
