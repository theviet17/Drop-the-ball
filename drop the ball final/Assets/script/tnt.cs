using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tnt : MonoBehaviour
{
    // Start is called before the first frame update

    bool check1;
    float time;
    public GameObject pr;
    public GameObject bum;
    public GameObject bumeffect;
    void Start()
    {

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (check1 == true)
        {
            time += Time.deltaTime;
        }

        if (time > 0.1)
        {
            Destroy(pr);

        }
    }
    void Update()
    {


    }
    private void OnCollisionEnter(Collision collision)
    {
 

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "target" || other.gameObject.tag == "tnt")
        {

            check1 = true;
            Destroy(pr);
            gameObject.SetActive(false);
            Instantiate(bum, transform.position, Quaternion.identity);
            Instantiate(bumeffect, transform.position + new Vector3(0, -6, 1), Quaternion.identity);
        }

    }
}
