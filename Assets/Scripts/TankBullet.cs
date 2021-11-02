using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBullet : MonoBehaviour
{

    //public Rigidbody Shell;

    public GameObject fireStart;
    public GameObject rocket;
    public int rocketAmmo;
    public bool isBulletEmpty;
    public Vector3 vec;
    Rigidbody rb;
    private void Start()
    {
        rocketAmmo = 1;
        isBulletEmpty = false;

        rb = GetComponent<Rigidbody>();
    }

    public void Shoot()
    {
        rocket = Instantiate(rocket, vec, Quaternion.identity);
        rocketAmmo++;   
    }
    private void Update()
    {
         vec = new Vector3(fireStart.transform.position.x, fireStart.transform.position.y, fireStart.transform.position.z);
        if (Input.touchCount > 0)
        {
            Touch finger = Input.GetTouch(0);
            if (finger.phase == TouchPhase.Ended)
            {
                if (VehicleController.isThisTank == true)
                Shoot();       
            }
        }
    }
    

}
