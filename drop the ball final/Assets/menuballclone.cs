using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuballclone : MonoBehaviour
{
    // Start is called before the first frame update
    public Material[] ma;
    Renderer rend;
    int point;
    void Start()
    {
        rend = GetComponent<Renderer>(); ;
        rend.enabled = true;
        point = Random.Range(1, 8);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(transform.position.y < -5)
        {
            Destroy(gameObject);
        }
        if (point == 1)
        {
            rend.sharedMaterial = ma[0];

        }
        if (point == 2)
        {
            rend.sharedMaterial = ma[1];
        }
        if (point == 3)
        {
            rend.sharedMaterial = ma[2];
        }
        if (point == 4)
        {
            rend.sharedMaterial = ma[3];
        }
        if (point == 5)
        {
            rend.sharedMaterial = ma[4];
        }
        if (point == 6)
        {
            rend.sharedMaterial = ma[5];
        }
        if (point == 7)
        {
            rend.sharedMaterial = ma[6];
        }
        if (point >= 8)
        {
            rend.sharedMaterial = ma[7];
        }
    }
}
