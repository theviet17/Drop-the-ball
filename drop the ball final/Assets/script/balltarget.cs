using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balltarget : MonoBehaviour
{
    // Start is called before the first frame update

    public bool isLog = true;
    float bnus;
    void Start()
    {
       
    }
    private void FixedUpdate()
    {
        bnus = PlayerPrefs.GetFloat("bonus");
    }   
}
