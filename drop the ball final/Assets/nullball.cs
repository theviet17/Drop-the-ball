using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nullball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z == 0.75)
        {
            transform.position = transform.position + new Vector3(0, 0, -0.45f);
        }
        if (transform.position.z == 0)
        {
            transform.position = transform.position + new Vector3(0, 0, -0.5f);
        }

    }
}
