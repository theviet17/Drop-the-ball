using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuball : MonoBehaviour
{
    // Start is called before the first frame update\
    public GameObject ball;
    public int randomz;
    float timez;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timez += Time.deltaTime;
        randomz = Random.Range(-2, 2);
        if(timez > 1) { 
        Instantiate(ball, transform.position + new Vector3(0, 0, randomz), Quaternion.identity);
            timez = 0;
        }

    }
}
