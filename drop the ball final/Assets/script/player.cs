using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    //   public Rigidbody body;
    public TMP_Text text;
    public Material[] ma;
    Renderer rend;
    public float point;
    float lv;
    public bool Lock;
    int minpoint = 1;
    int maxpoint = 4;
    int checklv;
    float power = 1;
   // float pointmain;
    public Animator animator;
    public  bool isbonus;
   // public bool isdestroy = false;


    void Start()
    {
        animator = GetComponent<Animator>();
        rend = GetComponent<Renderer>(); ;
        rend.enabled = true;


        point = Random.Range(1,2);

        text.text = point.ToString();
        Lock = true;
        lv = PlayerPrefs.GetFloat("lv");
      //  pointmain = 0;
      //  PlayerPrefs.SetFloat("point", pointmain);
        isbonus = true;
       
    }
    private void FixedUpdate()
   {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.W))
        lv = PlayerPrefs.GetFloat("lv");

       
        checklv = (int) (lv/25);
     
        if (Lock == false)
        {
            point = Random.Range(minpoint + checklv, maxpoint + checklv);
        }
        text.text = point.ToString();
        power = PlayerPrefs.GetFloat("power");


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
        if (point ==6)
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
        if (point <= 0) { 
        Destroy(gameObject);
            Destroy(text);
        }
        if (point <= power)
        {
            gameObject.tag = "getpoint";

        }
        if (point > power)
        {
            gameObject.tag = "ob";

        }

    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "target")
        {
            point = point - power;
            if (point < 0) { point = 0; }
            text.text = point.ToString();
        }
       

    }
    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "pl")
        {
            Lock = true;

        }
      
    }
    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "pl")
        {
            Lock = false;
        }
        if(collision.gameObject.tag == "bonus")
        {
            if (isbonus == true)
            {
                isbonus = false;
            }
        }
       
    }
    void OnTriggerEnter(Collider other) 
    {
      if (other.gameObject.tag == "wall")
        {
           //Destroy(gameObject);
        }
        if (other.gameObject.tag == "wrn")
        {
            animator.SetBool("wrn", true);
        }
      if (other.gameObject.tag == "boom" || other.gameObject.tag == "tnt")
        {
           // Destroy(gameObject);
           // Debug.Log(other.gameObject.name);

        }
    }

  //  public void retur()
   // {
      
  //  }
    
    
}
