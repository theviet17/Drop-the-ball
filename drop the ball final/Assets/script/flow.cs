using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flow : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 offset;
    public bool start = false;
    float elapsedTime;
    public Vector3 startPosition;
    public AnimationCurve curve;
    public float x = 1;
    public int tmscl = 1;
    // [SerializeField] private float smoothness;
    private void Start()
    {
        startPosition = transform.position;
    }

    public void Update()
    {
        
     Time.timeScale = tmscl;
        
        
        //if (player != null)
        //{
        elapsedTime += Time.deltaTime;
        
        if (start == true)
        {

            elapsedTime = 0;
            if (Time.timeScale != 0)
            {
            float strength = curve.Evaluate(elapsedTime / 0.5f);
            transform.position = startPosition + Random.insideUnitSphere * strength * x ;
            }


        }


    }
    public void flowplane()
    {
        transform.position = transform.position + new Vector3(0, -2.6f, 0);
        startPosition = transform.position;
    }
}
