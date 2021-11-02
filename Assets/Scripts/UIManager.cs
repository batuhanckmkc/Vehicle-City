using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.Collections.Generic;
public class UIManager : MonoBehaviour
{
    public GameObject healthPopUp;
    public GameObject shopScreen;
    public GameObject[] ImproveButton;
    public GameObject improveMainButton;
    public GameObject shopButtonOn;
    public GameObject shopButtonOff;
    public float timer;
    public static int speedAmount, improveIndex;
    public GameObject notEnoughMoney;
    public Text input;
    public Text speedText;
    public Text remainingText;
    private int convertIntegerLetter;
    public static bool isOnShop;

    void Start()
    {
        int.TryParse(input.text, out convertIntegerLetter);
        //PlayerPrefs.DeleteKey("SpeedAmount");
        //PlayerPrefs.DeleteKey("Improve");
        //PlayerPrefs.DeleteAll();
        speedAmount = PlayerPrefs.GetInt("SpeedAmount");
        Debug.Log("Speed" + " " + speedAmount);
        improveMainButton.SetActive(true);
        
        
        
        if(PlayerPrefs.HasKey("Improve"))
        {
            improveIndex = PlayerPrefs.GetInt("Improve");

            foreach (var item in ImproveButton)
            {
                ImproveButton[improveIndex].SetActive(true);
            }
        }
        else
        {
            ImproveButton[improveIndex].SetActive(true);
        }
      
    }

    void Update()
    {
        //Debug.Log("Improve Index:" + " " + improveIndex);
    }

    public void shopButtonActivate()
    {
        ImproveButton[improveIndex].SetActive(false);
        shopButtonOn.SetActive(false);
        shopButtonOff.SetActive(true);
        isOnShop = true;
        healthPopUp.SetActive(false);
    }

    public void shopButtonDectivate()
    {
        ImproveButton[improveIndex].SetActive(true);
        shopButtonOff.SetActive(false);
        shopButtonOn.SetActive(true);
        isOnShop = false;
        healthPopUp.SetActive(true);
    }

    public void speedBoost()
    {
        if(improveIndex < 5)
        {
            ImproveButton[improveIndex].SetActive(false);
        }
        switch (improveIndex)
        {
            case 0:
                if(VehicleController.currentCoins >= convertIntegerLetter)
                {
                    VehicleController.currentCoins -= convertIntegerLetter;
                    speedAmount = speedAmount + 10;
                    improveIndex++;
                    PlayerPrefs.SetInt("Improve", improveIndex);
                    ImproveButton[improveIndex].SetActive(true);
                    PlayerPrefs.SetInt("SpeedAmount", speedAmount);
                }
                else
                {
                    //notEnoughMoney.SetActive(true);
                }
                break;
            case 1:
                if (VehicleController.currentCoins >= 500)
                {
                    VehicleController.currentCoins -= 500;
                    speedAmount = speedAmount + 20;
                    improveIndex++;
                    PlayerPrefs.SetInt("Improve", improveIndex);
                    ImproveButton[improveIndex].SetActive(true);
                    PlayerPrefs.SetInt("SpeedAmount", speedAmount);
                }
                else
                {
                    //notEnoughMoney.SetActive(true);
                }
                break;
            case 2:
                if (VehicleController.currentCoins >= 1000)
                {
                    VehicleController.currentCoins -= 1000;
                    speedAmount = speedAmount + 30;
                    improveIndex++;
                    PlayerPrefs.SetInt("Improve", improveIndex);
                    ImproveButton[improveIndex].SetActive(true);
                    PlayerPrefs.SetInt("SpeedAmount", speedAmount);
                }
                else
                {
                    //notEnoughMoney.SetActive(true);
                }
                break;
            case 3:
                if (VehicleController.currentCoins >= 2000)
                {
                    VehicleController.currentCoins -= 2000;
                    speedAmount = speedAmount + 40;
                    improveIndex++;
                    PlayerPrefs.SetInt("Improve", improveIndex);
                    ImproveButton[improveIndex].SetActive(true);
                    PlayerPrefs.SetInt("SpeedAmount", speedAmount);
                }
                else
                {
                    //notEnoughMoney.SetActive(true);
                }
                break;
            case 4:
                if (VehicleController.currentCoins > 5000)
                {
                    VehicleController.currentCoins -= 5000;
                    speedAmount = speedAmount + 50;
                    improveIndex++;
                    PlayerPrefs.SetInt("Improve", improveIndex);
                    ImproveButton[improveIndex].SetActive(true);
                    PlayerPrefs.SetInt("SpeedAmount", speedAmount);
                }
                else
                {
                    //notEnoughMoney.SetActive(true);
                }
                break;     
        }
    }
}
