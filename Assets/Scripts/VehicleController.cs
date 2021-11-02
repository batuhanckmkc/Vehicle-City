using UnityEngine;
using UnityEngine.UI;

public class VehicleController : MonoBehaviour
{
    public Text healthText, scoreText, goldText;
    //public Text scoreText;
    //public Text goldText;
    public Text highScoreText;
    private int temp, highScoreNumber, goldTemp, index;
    public static int tankCoinCollect;
    public Transform scoreHandler;
    public GameObject[] particleEffect;
    public GameObject[] vehicles;
    public static int vehicleIndex = 0;
    [SerializeField] HealthSystem healthSystem;
    [SerializeField] EndScreen endScreen;
    [SerializeField] TouchMovement touchMovement;
    [SerializeField] Timer timer;
    [SerializeField] VehicleCarManager vehicleCarManager;
    [SerializeField] PoliceCar policeCar;
    [SerializeField] MafiaCar mafiaCar;
    [SerializeField] Tank tank;
    [SerializeField] Car car;
    [SerializeField] Vosvos vosvos;
    [SerializeField] Broadway broadway;
    //[SerializeField] BlackTofas blackTofas;
    public static int currentVehicleSpeed;
    public GameObject[] vehicleTank;
    public GameObject vehicle;
    public static bool isThisTank;
    public int remainingSeconds;
    //private int goldTemp;
    public static int currentCoins;
    //private int index;
    public static int health;
    Rigidbody vehicleRb;
    // Start is called before the first frame update
    void Start()
    {

        health = 3;
        //PlayerPrefs.DeleteKey("Gold");
        if (PlayerPrefs.HasKey("Gold"))
        {
            currentCoins = PlayerPrefs.GetInt("Gold");
        }
        tankCoinCollect = 0;
        Debug.Log("Start yine çalýþtý");
        goldText.text = currentCoins.ToString();
        remainingSeconds = Timer.remainingDuration;
        currentVehicleSpeed = 0;
        vehicles[vehicleIndex].SetActive(true);
        vehicleRb = GetComponent<Rigidbody>();
        isThisTank = false;
    }
    void FixedUpdate()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScore", temp).ToString();
        Debug.Log(temp);
        Debug.Log("Highscore:" + " " + highScoreNumber);
        goldText.text = ((temp / 60) + tankCoinCollect + currentCoins).ToString();
        healthText.text = health.ToString();
        if (touchMovement.isTouched == true)
        {
            scoreText.text = (scoreHandler.position.z * 30).ToString("0");
            int.TryParse(scoreText.text, out temp);
            int.TryParse(goldText.text, out goldTemp);
            vehicleRb.velocity = (Vector3.forward * Time.deltaTime * currentVehicleSpeed);
            switchCase();
            tankController();
            timerController();
            //Debug.Log(currentCoins);
            //Debug.Log(goldTemp);
        }
    }
    // Update is called once per frame
    void switchCase()
    {
        switch (vehicleIndex)
        {
            case 0:
                currentVehicleSpeed = car.vehicleTofas.vehicleSpeed + UIManager.speedAmount;
                Debug.Log(currentVehicleSpeed);
                break;
            case 1:
                currentVehicleSpeed = vosvos.vehicleVosVos.vehicleSpeed + UIManager.speedAmount;
                Debug.Log(currentVehicleSpeed);
                break;
            case 2:
                currentVehicleSpeed = broadway.vehicleBroadway.vehicleSpeed + UIManager.speedAmount;
                Debug.Log(currentVehicleSpeed);
                break;
            case 3: 
                currentVehicleSpeed = policeCar.vehiclePolice.vehicleSpeed + UIManager.speedAmount;
                Debug.Log(currentVehicleSpeed);
                break;
            case 4:
                currentVehicleSpeed = mafiaCar.vehicleMafia.vehicleSpeed + UIManager.speedAmount;
                Debug.Log(currentVehicleSpeed);
                break;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "UpgradeWall")
        {
            if (vehicleIndex <= 3)
            {
                Vector3 posX = new Vector3(vehicle.transform.position.x, vehicle.transform.position.y, vehicle.transform.position.z);
                GameObject particleEffect1 = Instantiate(particleEffect[0], posX, Quaternion.Euler(0, 0, 0));
            }
            vehicles[vehicleIndex].SetActive(false);
            if (isThisTank == false)
            {
                upgradeVehicle();
                //Debug.Log("Upgrade çalýþtý");
            }

        }
        if (other.gameObject.tag == "LowerWall")
        {
            if(vehicleIndex > 0)
            {
                Vector3 posY = new Vector3(vehicle.transform.position.x, vehicle.transform.position.y, vehicle.transform.position.z);
                GameObject particleEffect2 = Instantiate(particleEffect[1], posY, Quaternion.Euler(0, 0, 0));
            }
            vehicles[vehicleIndex].SetActive(false);
            if (vehicleIndex == 0)
            {
                health--;
                //healthSystem.healtImageIndex--;
                if (health <= 0)
                {
                    saveHighScore();
                    PlayerPrefs.SetInt("Gold", goldTemp);
                    saveHighScore();
                    endScreen.checkGameOver();
                    Destroy(gameObject);
                }
            }
            if (isThisTank == false)
            {
                lowerVehicle();
            }
           
            //Debug.Log("Lower çalýþtý");

        }
        if (other.gameObject.tag == "PurpleWall")   
        {
            Vector3 posXY = new Vector3(vehicle.transform.position.x, vehicle.transform.position.y, vehicle.transform.position.z);
            GameObject particleEffect3 = Instantiate(particleEffect[2], posXY, Quaternion.Euler(0, 0, 0));
            index = Random.Range(0, 3);
            vehicles[vehicleIndex].SetActive(false);
            vehicleTank[index].SetActive(true);
            timer.uiGameObject.SetActive(true);
            timer
                .SetDuration(3)
                .OnBegin (() => Debug.Log ("Timer Started"))
                .OnChange (remainingSeconds => Debug.Log ("Timer changed" + remainingSeconds))
                .OnEnd (() => Debug.Log("Timer Ended"))
                .Begin ();
            isThisTank = true;
        }
        if(other.gameObject.tag == "DeadlyBarrier")
        {
            vehicles[vehicleIndex].SetActive(false);
            saveHighScore();
            PlayerPrefs.SetInt("Gold", goldTemp);
                saveHighScore();
                endScreen.checkGameOver();
                Destroy(gameObject);
                deadlyBarrier();
        }
    }
    void reactivateVehicles()
    {
        vehicleTank[index].SetActive(false);
        vehicles[vehicleIndex].SetActive(true);
    }

    void deadlyBarrier()
    {
        vehicleIndex = 0;
    }
    void upgradeVehicle()
    {

        if (vehicleIndex < vehicles.Length - 1)
        {
            vehicleIndex++;
            //Debug.Log(vehicleIndex);
        }
        vehicles[vehicleIndex].SetActive(true);
    }

    void lowerVehicle()
    {

        if (vehicleIndex > 0)
        {
           
            vehicleIndex--;
            Debug.Log(vehicleIndex);
        }
        vehicles[vehicleIndex].SetActive(true);
    }
    void tankController()
    {
        if (isThisTank == true)
        {
            currentVehicleSpeed = tank.vehicleTank.vehicleSpeed;
        }
    }
    
    void saveHighScore()
    {
        if (temp > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", temp);
        }
    }
    void timerController()
    {
        if (Timer.remainingDuration == -1)
        {
            reactivateVehicles();
            timer.uiGameObject.SetActive(false);
            isThisTank = false;
        }
    }

}
