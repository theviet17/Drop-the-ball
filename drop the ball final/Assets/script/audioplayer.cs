﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioplayer : MonoBehaviour
{
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "e3" )
        {
            //Debug.Log(collision.gameObject.name);
           audioSource.Play();
        }
        
    }
}
