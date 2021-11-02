using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessRoad : MonoBehaviour
{
    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            transform.position += new Vector3(0, 0, transform.GetComponent<Renderer>().bounds.size.z * 3);
        }

    }
}
