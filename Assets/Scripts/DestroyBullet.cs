using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    //Rigidbody rb;
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        Destroy(gameObject, 3f);
    }

    /*private void FixedUpdate()
    {
        rb.velocity = (Vector3.forward * Time.deltaTime * 500f);
    }*/
}
