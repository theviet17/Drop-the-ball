using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTargetBall : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject balltnt;
    [SerializeField] private GameObject ballboom;
    [SerializeField] private Transform TargetBallClone;

    private Vector3 currentPosition = new Vector3(0, 0, 0);

    private void Start()
    {
            SpawnTerrain();
            SpawnTerrain2();
    }
    public void SpawnTerrain()
    {
        float currentz = 0;
        float getz;
        for (int i = 1; i <= getNumberofballs(); i = i)
        {
            getz = getrandomz_1();
            if (getz != currentz) // nếu vị trí của ball sau trùng với ball trước thì lấy lại Z, nếu không thì instantiate
            {
                currentz = getz;
                string randomBtb = randomBall_Tnt_Boom();
                if (randomBtb == "ball")
                {
                    GameObject balls = Instantiate(ball, new Vector3(0, currentPosition.y, currentz), Quaternion.identity);
                    balls.transform.SetParent(TargetBallClone);
                }
                else if (randomBtb == "tnt")
                {
                    GameObject balls = Instantiate(balltnt, new Vector3(0, currentPosition.y, currentz), Quaternion.identity);
                    balls.transform.SetParent(TargetBallClone);
                }
                else
                {
                    GameObject balls = Instantiate(ballboom, new Vector3(0, currentPosition.y, currentz), Quaternion.identity);
                    balls.transform.SetParent(TargetBallClone);
                }
                i++;
            }   
        }
        currentPosition.y -= 1.3f;
    }
    public void SpawnTerrain2()
    {
        float currentz = 0;
        float getz;
        for (int i = 1; i <= getNumberofballs(); i = i)
        {
            getz = getrandomz_2();
            if (getz != currentz)  // nếu vị trí của ball sau trùng với ball trước thì lấy lại Z, nếu không thì instantiate
            {
                currentz = getz;
                string randomBtb = randomBall_Tnt_Boom();
                if (randomBtb == "ball")
                {
                    GameObject balls = Instantiate(ball, new Vector3(0, currentPosition.y, currentz), Quaternion.identity);
                    balls.transform.SetParent(TargetBallClone);
                }
                else if (randomBtb == "tnt")
                {
                    GameObject balls = Instantiate(balltnt, new Vector3(0, currentPosition.y, currentz), Quaternion.identity);
                    balls.transform.SetParent(TargetBallClone);
                }
                else
                {
                    GameObject balls = Instantiate(ballboom, new Vector3(0, currentPosition.y, currentz), Quaternion.identity);
                    balls.transform.SetParent(TargetBallClone);
                }
                i++;
            } 
        }
        currentPosition.y -= 1.3f;
    }
    string randomBall_Tnt_Boom()
    {
        int perCent = Random.Range(0, 100);

        if (perCent < 70)
        {
            return "ball";
        }
        else if (perCent >= 70 && perCent < 85)
        {
            return "tnt";
        }
        else
        {
            return "boom";
        }
    }
    int getNumberofballs()
    {
        int perCent = Random.Range(0, 100);

        if (perCent < 50)    
        {
            return 1;
        }
        else if (perCent >= 50 && perCent < 80)     
        {
            return 2; 
        }
        else if (perCent >= 80 && perCent < 90)     
        {
            return 3; 
        }
        else if (perCent >= 90 && perCent < 95)     
        {
            return 4; 
        }
        else   
        {
            return 5; 
        }

    }
    float getrandomz_1()
    {
        int perCent = Random.Range(0, 120);

        if (perCent < 20)    
        {
            return 4;
        }
        else if (perCent >= 20 && perCent < 40)     
        {
            return 2.5f;
        }
        else if (perCent >= 40 && perCent < 60)     
        {
            return 1;
        }
        else if (perCent >= 60 && perCent < 80)     
        {
            return -0.5f;
        }
        else if (perCent >= 80 && perCent < 100)
        {
            return -2;
        }
        else   //10%
        {
            return -3.5f;
        }

    }
    float getrandomz_2()
    {
        int perCent = Random.Range(0, 100);

        if (perCent < 20)
        {
            return 3.25f;
        }
        else if (perCent >= 20 && perCent < 40)
        {
            return 1.75f;
        }
        else if (perCent >= 40 && perCent < 60)
        {
            return 0.25f;
        }
        else if (perCent >= 60 && perCent < 80)
        {
            return -1.25f;
        }
        else 
        {
            return -2.75f;
        }
     

    }
}
