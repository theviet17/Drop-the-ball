using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shadowplayer : MonoBehaviour
{
    float time;
    public GameObject shadow;
    public Transform shadowclone;

    void Start()
    {
        shadow.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        time = time + Time.deltaTime;
        if(time > 0.03) { 
            shadow = Instantiate(shadow, transform.position + new Vector3 (0.1f,0,0), Quaternion.identity);
            shadow.transform.SetParent(shadowclone);
            time = 0;
        }

    }
}
