using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playermain : MonoBehaviour
{
    [SerializeField] public plane planet;
    public Text txt;
    public Text txtbest;
    public Text powertxt;
    public Text booms;
    public GameObject plent;
    public shootpoint st;


    public Rigidbody body;
    public float speed = 0.05f;
    float timetoreturn;
    float x;
    public float point;
    public float bestpoint = 0;
    int powerpoint;
    int power = 1;
    int checkpowerpoint;
    public GameObject shadow;
    public flow fl;
    float timeshake;
    float timetostart;
    bool isstart = false;
    float bnus; // tình điểm bonus
    bool isbonus= true; // kiểm tra xem đã bonus chưa , nếu chưa bonus thì sẽ cộng điểm bonus và để bonus = false để không bonus liên tục
    bool isstartbonus = false;  // kiểm tra xem game bát đầu chưa tránh việc đầu game chưa có bóng sẽ cộng ngay bonus
    public bool isballinbonus = false; // kiểm tra có bóng trong vùng bonus không
    float bonuspoint;

    public GameObject popbonus;
    public GameObject bonuseffect;

    bool deley;
    float timedelay;

    public GameObject btnpause;
    public GameObject btnresum;
    int tmscl =1;
    bool checkpause;



    void Start()
    {
        
        body = gameObject.GetComponent<Rigidbody>();
        body.isKinematic = true;
        bestpoint = PlayerPrefs.GetFloat("bestpoint");
        PlayerPrefs.SetFloat("lv", point);
        btnresum.SetActive(false);

    }
    

    private void FixedUpdate()
    {
       /// bnus = PlayerPrefs.GetFloat("bonus");
      

        timeshake += Time.deltaTime;
        if (timeshake > 0.1f)
        {
            fl.start = false;
            fl.transform.position = fl.startPosition;
        }
        if (body.isKinematic == false) 
        { 
        if (Mathf.Abs(transform.position.y) - Mathf.Abs(x) != 0)
        {
            x = transform.position.y;
            timetoreturn = 0;
        }
        if (Mathf.Abs(transform.position.y) - Mathf.Abs(x) == 0)
        {
            timetoreturn = timetoreturn + Time.deltaTime;
        }
        }
        if (timetoreturn >= 1)
        {
            retur();
        }

        powertxt.text = "Power: " + power;
        booms.text = "Booms: " + powerpoint;
        if (powerpoint > checkpowerpoint)
        {
            checkpowerpoint = powerpoint;
            if(powerpoint % 5 == 0)
            {
                power++;
            }
        }
        PlayerPrefs.SetFloat("power",  power);
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            if (checkpause == true)
            {
                resum();

            }

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
                checkpause = false;
            

        }
        Time.timeScale = tmscl;

        if (body.isKinematic == true)
        {
            if (Input.GetMouseButton(0))
            {
                bonuspoint = PlayerPrefs.GetFloat("bonus");
            }

          }


        txt.text = point.ToString();
        txtbest.text = "Best " + bestpoint; 
        point = PlayerPrefs.GetFloat("lv");

        timetostart += Time.deltaTime;
        if (timetostart > 0.1)
        {
            if (isstart == false)
            {
                
                retur();
               
                isstart = true;

            }
        }
        if (deley == true)
        {
            timedelay += Time.deltaTime;
            if (timedelay > 0.1)
            {
                planet.reup();
                gameObject.transform.position =  new Vector3(0, plent.transform.position.y + 23.5f, 0);
                deley = false;
                timedelay = 0;

            }
        }
        if (timetostart > 1)
        {
          
                isstartbonus = true;
        }

        if (isstartbonus == true)
        {
             
           if (isbonus == true)
           {

                bnus = PlayerPrefs.GetFloat("bonus");
                if(bnus < 0)
                {
                   // bnus = 0;
                   // PlayerPrefs.SetFloat("bonus",bnus);
                }
                if (bnus == 0)
                {
                    if (isballinbonus == true)
                    {
                        float textbonus = 5 + bonuspoint;
                        //point +=5;
                        point += textbonus;
                        PlayerPrefs.SetFloat("lv", point);
                        
                        PlayerPrefs.SetFloat("textbonus", textbonus);
                        Instantiate(bonuseffect, popbonus.transform.position + new Vector3(0,-15,-1), Quaternion.identity);
                        isballinbonus = false;
                    }
                    
                }
                
                isbonus = false;
            }
        }
        

        if (point > bestpoint)
        {
            PlayerPrefs.SetFloat("bestpoint", point);
        }

    }

    public void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.tag == "getpoint" || collision.gameObject.tag == "ob")
        {
            timeshake = 0;

            fl.x += 0.25f;
            if (fl.x > 1.75)
            {
                fl.x = 1.75f;
            }
         
            fl.start = true;
          
        }
        
        if (collision.gameObject.tag == "boom")
        {
            timeshake = 0;

            fl.start = true;
            powerpoint++;

            deley = true;
            retur();

        }
        if (collision.gameObject.tag == "e11")
        {

            Destroy(collision.gameObject);

        }


        //  timetoreturn = timetoreturn + Time.deltaTime;

    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "pl" || other.gameObject.tag == "returnline")
        {
            // bonuspoint = 0;
          //  Debug.Log(other.gameObject.name);
            deley = true;
            retur();
            

        }
       
        if (other.gameObject.tag == "wall")
        {
            timeshake = 0;
            fl.x =1 ;
            fl.start = true;
            
            //Debug.Log(1);

        }
    }
    public void retur()
    {
        body.isKinematic = true;
        
        gameObject.transform.position = new Vector3(0, plent.transform.position.y + 30, 0);
        //gameObject.SetActive(false);
        deley = true;
        // pl.reup();
        fl.x = 1;
        timetoreturn = 0;
        isbonus = true;
        //Debug.Log(1);
    }
    public void pause()
    {
        st.tmscl = 0;
        fl.tmscl = 0;
        tmscl = 0;
        checkpause = true;
        btnpause.SetActive(false);
        btnresum.SetActive(true);

    }
    public void resum()
    {
        st.tmscl = 1;
        fl.tmscl = 1;
        tmscl = 1;
        btnpause.SetActive(true);
        btnresum.SetActive(false);
        

    }
    
}
