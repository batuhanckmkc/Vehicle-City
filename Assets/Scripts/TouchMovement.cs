using UnityEngine;

public class TouchMovement : MonoBehaviour
{
    public float valueLeft = -0.033f, valueRight = 0.63f, value;
    public bool isTouched;
    public TouchStart touch_Start;
    public float screenWidth;
    Vector3 vec = Vector3.zero;


    private void Start()
    {
        screenWidth = Screen.width;
    }
    void FixedUpdate()
    {
        //transform.position = new Vector3(value, transform.position.y, transform.position.z);
    }

    void LateUpdate()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            value = 0.63f;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            value = -0.033f;
        }
    }
    void Update()
    {
        if (Input.touchCount > 1)
        {
            if (UIManager.isOnShop == false)
            {
                touch_Start.deactivatePopUp();
                isTouched = true;
            }
        }
        if (Input.touchCount > 0)
        {
            //Debug.Log("Dokunuyorsun");
            Touch finger = Input.GetTouch(0);
            /*if(finger.phase == TouchPhase.Ended)
            {
                if(VehicleController.isThisTank == true)
                //TankBullet;
                {

                }
            }*/

            if (finger.deltaPosition.x > 25f)
            {

                if (finger.phase == TouchPhase.Moved)
                    transform.position = new Vector3(valueRight, transform.position.y, transform.position.z);
                    /*vec = new Vector3(valueRight, transform.position.y, transform.position.z);
                transform.position = Vector3.Lerp(transform.position, vec, 0.9f);*/
                //Debug.Log("Saða gitti");
            }
            if (finger.deltaPosition.x < -25f)
            {
                if (finger.phase == TouchPhase.Moved)
                    transform.position = new Vector3(valueLeft, transform.position.y, transform.position.z);
                   /* vec = new Vector3(valueLeft, transform.position.y, transform.position.z);
                transform.position = Vector3.Lerp(transform.position, vec, 0.9f);*/
                //Debug.Log("Sola gitti");
            }
        }
    }
}
