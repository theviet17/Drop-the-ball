using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pop1 : MonoBehaviour
{
   // public GameObject target;
    bool isPop;
    float timer;
    bool isbum = true;
    public GameObject bum;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.GetChild(0).name == "text")
        {
            isPop = true;
        }
       
        //if (Input.GetKeyUp(KeyCode.W)) { 
        if (isPop == true)
    
      {

            if(isbum == true) 
            { 
              Instantiate(bum, transform.position + new Vector3(0, -1, 0), Quaternion.identity).transform.SetParent(gameObject.transform);
              isbum = false;
            }
            timer += Time.deltaTime;
            transform.GetChild(0).position = Vector3.Lerp(transform.GetChild(0).position, transform.position + new Vector3(0,13,0), Time.deltaTime * 0.5f);
            transform.GetChild(1).position =  transform.position + new Vector3(0, 50, 0);
            if (timer > 0.7)
            {
                gameObject.SetActive(false);
            }
            // }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "target")
        {
           // isPop = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ob")
        {
            //Debug.Log(1);
        }
    }
}
