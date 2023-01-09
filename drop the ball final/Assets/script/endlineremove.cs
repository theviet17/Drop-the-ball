using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endlineremove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag != "target" || other.gameObject.tag != "boom")
        {
            Destroy(other.gameObject);
        }
      
    }
}
