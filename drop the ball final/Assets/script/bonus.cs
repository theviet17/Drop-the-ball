using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonus : MonoBehaviour
{
    public playermain player;
    float bnus = 0f;
    float point;
   // public GameObject bonuseffect;

    void Start()
    {
        PlayerPrefs.SetFloat("bonus", bnus);
       
    }

    void Update()
    {
         bnus = PlayerPrefs.GetFloat("bonus");
        point = PlayerPrefs.GetFloat("lv");

        //Debug.Log(bnus);

        if(bnus == 0)
        {
           
        }

    }
    void OnTriggerStay(Collider collision)
    {
  
        if (collision.GetComponent<player>() != null)                        
        {
            player.isballinbonus = true;
            if (collision.GetComponent<player>().isbonus == true)
            {
                
                   // bnus = PlayerPrefs.GetFloat("bonus");
                    bnus++;
                    PlayerPrefs.SetFloat("bonus", bnus);
                

            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "-bnus")
        {
            //Debug.Log(other.gameObject.name);

           // bnus = PlayerPrefs.GetFloat("bonus");
            bnus--;
            PlayerPrefs.SetFloat("bonus", bnus);




            point++;
            PlayerPrefs.SetFloat("lv", point);
        }
    }
}
