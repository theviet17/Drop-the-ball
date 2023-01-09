using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootpoint : MonoBehaviour
{
    // Start is called before the first frame update
    float xRot = 0f;
    float zRot = 0f;
    public Rigidbody ball;
    public float roatationSpeed = 5f;
    public float shootPower = 1000f;
    public LineRenderer line;
    public int tmscl = 1;


    

    void Start()
    {
        
    }

    //Update is called once per frame
    void Update()
    {

        Time.timeScale = tmscl;

        

            if (ball.isKinematic == true)
            {
                transform.position = ball.position;
                if (Input.GetMouseButton(0))
                {
                if (Time.timeScale != 0)
                {
                   


                    xRot += Input.GetAxis("Mouse X") * roatationSpeed;
                    zRot += Input.GetAxis("Mouse Y") * roatationSpeed;
                    transform.rotation = Quaternion.Euler(xRot, 0f, zRot);
                    line.gameObject.SetActive(true);
                    line.SetPosition(0, transform.position);
                    line.SetPosition(1, transform.position + transform.forward * 4f);


                }

            }
            if (Input.GetMouseButtonUp(0))
            {
                if (Time.timeScale != 0)
                {
                    ball.velocity = transform.forward * shootPower;
                    ball.isKinematic = false;
                    line.gameObject.SetActive(false);
                }
            }
        
        }
    }
 


}
