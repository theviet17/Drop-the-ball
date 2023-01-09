using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boom : MonoBehaviour
{
    // Start is called before the first frame update
 
    bool check;
    float time;
    public GameObject bum;
    public GameObject pr;
    public bool Lock;
    public GameObject popbom;
    public GameObject boomtext;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
       if (check== true)
        {
           time = time + Time.deltaTime;
        }
        if (time > 0.01)
        {
            Destroy(pr);
        }
    }
    void Update()
    {

        
    }
    private void OnCollisionEnter(Collision collision)
    {
     if(collision.gameObject.tag == "target")
        {
            Instantiate(popbom, transform.position + new Vector3(0,1,0), Quaternion.identity);
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
    }

        private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "tnt")
        {

            if(Lock == true)
            {
                
                check = true;
                Instantiate(bum, transform.position, Quaternion.identity);
                Instantiate(boomtext,transform.position+ new Vector3(-3,0,0), Quaternion.identity);
                gameObject.SetActive(true);
            }


        }
        if (other.gameObject.tag == "ob" || other.gameObject.tag == "getpoint")
        {

            Destroy(other.gameObject);
        }
        

    }
}
