using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchStart : MonoBehaviour
{
    public GameObject ImproveButton;
    public GameObject touchStartPopUp;
    public GameObject scorePopUp;
    public GameObject goldPopUp;
    public GameObject shopPopUp;
    public GameObject healthPopUp;
    private void Start()
    {
        touchStartPopUp.SetActive(true);
        ImproveButton.SetActive(true);
        scorePopUp.SetActive(false);
        goldPopUp.SetActive(true);
        healthPopUp.SetActive(true);
    }
    public void deactivatePopUp()
    {
        touchStartPopUp.SetActive(false);
        ImproveButton.SetActive(false);
        scorePopUp.SetActive(true);
        goldPopUp.SetActive(true);
        shopPopUp.SetActive(false);
    }
    private void Update()
    {
        if(UIManager.isOnShop == true)
        {
            touchStartPopUp.SetActive(false);
        }
        if(UIManager.isOnShop==false && VehicleController.currentVehicleSpeed == 0)
        {
            touchStartPopUp.SetActive(true);
        }
    }
}
