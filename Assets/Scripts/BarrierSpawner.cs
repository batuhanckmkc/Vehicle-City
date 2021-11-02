using UnityEngine;

public class BarrierSpawner : WallDestroyer
{
    public GameObject[] barrier;
    public GameObject vehicle;
    public float temp,deadlyTemp;
    private int b;


    void Start()
    {
        Debug.Log(wallIndex);
        if(wallIndex == 1)
        {
            wallIndex--;
        }
    }


    void wallIndexCalculate()
    {
        if (wallIndex >= 1)
        {
            //Debug.Log("wallIndex:" + " " + wallIndex);
            //Debug.Log("If'e düþtü kardeþ!");
        }
        else
        {
            wallIndex++;
            //Debug.Log("wallIndex:" + " " + wallIndex);
            b = Random.Range(0, 9);
            switch (b)
            {
               case 0:

                    Vector3 posXY = new Vector3(0.23f, 0f, temp);
                    GameObject barrier0 = Instantiate(barrier[0], posXY, Quaternion.Euler(0, 0, 0));
                    Debug.Log("Case 0'a girdi:" + " " + barrier[0]);
;                   break;

                case 1:
                    if (VehicleController.isThisTank == false)
                    {
                        Vector3 posxYz = new Vector3(-0.06f, 0f, temp);
                        GameObject barrier1 = Instantiate(barrier[1], posxYz, Quaternion.Euler(0, 0, 0));
                        Debug.Log("Case 1'e girdi:" + " " + barrier[1]);

                        Vector3 posxY = new Vector3(0.578f, 0f, temp);
                        GameObject barrier3 = Instantiate(barrier[2], posxY, Quaternion.Euler(0, 0, 0));
                        Debug.Log("Case 1'e girdi:" + " " + barrier[2]);
                    }
                    else
                    {
                        Vector3 posxxy = new Vector3(0.23f, 0f, temp);
                        GameObject barrier2 = Instantiate(barrier[3], posxxy, Quaternion.Euler(0, 0, 0));
                        Debug.Log("Case 1'in else'ine girdi:" + " " + barrier[3]);
                    }

                    break;
                case 2:
                    if (VehicleController.isThisTank == false)
                    {
                        Vector3 posxYz = new Vector3(-0.06f, 0f, temp);
                        GameObject barrier1 = Instantiate(barrier[2], posxYz, Quaternion.Euler(0, 0, 0));
                        Debug.Log("Case 1'e girdi:" + " " + barrier[2]);

                        Vector3 posxY = new Vector3(0.578f, 0f, temp);
                        GameObject barrier3 = Instantiate(barrier[1], posxY, Quaternion.Euler(0, 0, 0));
                        Debug.Log("Case 1'e girdi:" + " " + barrier[1]);
                    }
                    else
                    {
                        Vector3 posxxy = new Vector3(0.23f, 0f, temp);
                        GameObject barrier2 = Instantiate(barrier[3], posxxy, Quaternion.Euler(0, 0, 0));
                        Debug.Log("Case 1'in else'ine girdi:" + " " + barrier[3]);
                    }

                    break;

                case 3:
                    Vector3 posxy = new Vector3(0.23f, 0f, temp);
                    GameObject yeni_Rwall = Instantiate(barrier[3], posxy, Quaternion.Euler(0, 0, 0));
                    Debug.Log("Case 2'ye girdi:" + " " + barrier[3]);
                    break;
                case 4:
                    Vector3 posxyy = new Vector3(0.23f, 0f, temp);
                    GameObject yeni_Rwalll = Instantiate(barrier[4], posxyy, Quaternion.Euler(0, 0, 0));
                    Debug.Log("Case 3'e girdi:" + " " + barrier[4]);
                    break;

                case 5:
                    Vector3 posxyyy = new Vector3(0.23f, 0f, temp);
                    GameObject yeni_Rwallll = Instantiate(barrier[5], posxyyy, Quaternion.Euler(0, 0, 0));
                    Debug.Log("Case 4'e girdi:" + " " + barrier[5]);
                    break;
                case 6:
                    Vector3 posx = new Vector3(0.23f, 0f, temp);
                    GameObject yeni_Rwalllll = Instantiate(barrier[6], posx, Quaternion.Euler(0, 0, 0));
                    Debug.Log("Case 5'e girdi:" + " " + barrier[6]);
                    break;
                case 7:
                    Vector3 posxyxy = new Vector3(-0.034f, 0f, deadlyTemp);
                    GameObject deadlyBarrier = Instantiate(barrier[7], posxyxy, Quaternion.Euler(0, 0, 0));
                    Debug.Log("Case 5'e girdi:" + " " + barrier[7]);

                    Vector3 posxyxyx = new Vector3(0.639f, 0f, deadlyTemp);
                    GameObject deadlyBarrierr = Instantiate(barrier[8], posxyxyx, Quaternion.Euler(0, 0, 0));
                    Debug.Log("Case 5'e girdi:" + " " + barrier[8]);
                    break;
                case 8:

                    Vector3 posxyxyxx = new Vector3(-0.034f, 0f, deadlyTemp);
                    GameObject deadlyBarrierrr = Instantiate(barrier[8], posxyxyxx, Quaternion.Euler(0, 0, 0));
                    Debug.Log("Case 5'e girdi:" + " " + barrier[8]);

                    Vector3 posxyxyxxx = new Vector3(0.639f, 0f, deadlyTemp);
                    GameObject deadlyBarrierrrr = Instantiate(barrier[7], posxyxyxxx, Quaternion.Euler(0, 0, 0));
                    Debug.Log("Case 5'e girdi:" + " " + barrier[7]);
                    break;

            }
        }

    }

    private void FixedUpdate()
    {
        temp = vehicle.transform.position.z + 6;
        deadlyTemp = vehicle.transform.position.z + 4;
        wallIndexCalculate();
    }
}
