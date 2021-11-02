using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadlyBarrier : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Tank")
        {
            Destroy(gameObject);
            WallDestroyer.wallIndex--;
        }
    }

    private void Update()
    {
        Destroy(gameObject, 5f);
    }
}
