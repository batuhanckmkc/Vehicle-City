using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour
{
    public GameObject goldPopUp, scorePopUp, healthPopUp;
    public VehicleController vehicleController;
    public TouchStart touchStart;
    public GameObject gameOverPopUp;
    public Text earnedText, highScoreText;
    private int currentCoins;
    void Start()
    {
        
    }

    public void checkGameOver()
    {
            gameOverPopUp.SetActive(true);
            currentCoins = PlayerPrefs.GetInt("Gold");
            highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
            earnedText.text = currentCoins.ToString();
            goldPopUp.SetActive(false);
            scorePopUp.SetActive(false);
            healthPopUp.SetActive(false);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
