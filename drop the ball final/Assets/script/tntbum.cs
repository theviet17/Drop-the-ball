using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tntbum : MonoBehaviour
{
 
    public bool isboom;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

    }
    private void OnTriggerEnter(Collider other)
    {
      
        if (other.GetComponent<player>() != null)
        {
           
            if (isboom == false)
            {

             if (other.GetComponent<player>().Lock == true)
            {
                if(other.GetComponent<player>().point <= 5) 
                { 
                Destroy(other.gameObject);

                
                }

                if(other.GetComponent<player>().point > 5)
                {
                    other.GetComponent<player>().point -= 5;
                }
            
                }

            }
        }
       
            if (other.GetComponent<player>() != null)
            {
           
                if (isboom == true)
                {
                    if (other.GetComponent<player>().Lock == true)
                    {

                    Destroy(other.gameObject);

                    }
                

            }
        }


    }
}
