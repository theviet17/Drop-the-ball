using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnifnull : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spawn;
    bool check = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.GetChild(0).name == "null")
        {
            if(check == true)
            {
                Instantiate(spawn,transform.position, Quaternion.identity);
                check = false;
            }
        }
    }
}
