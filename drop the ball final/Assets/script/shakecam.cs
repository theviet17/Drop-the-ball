using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shakecam : MonoBehaviour { 
    public bool start = false;
    float elapsedTime;
    public Vector3 startPosition;
    public AnimationCurve curve;
    void Start()
    {
         startPosition = transform.position;
    }
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (start == true)
        {
            elapsedTime = 0;
            
            float strength = curve.Evaluate(elapsedTime / 0.5f);
            transform.position = startPosition + Random.insideUnitSphere * strength;
        

        }
        if (elapsedTime > 0.3f)
        {
            start = false;
        }
        if(start == false)
        {
           // transform.position = startPosition;
        }
      
    }

}
