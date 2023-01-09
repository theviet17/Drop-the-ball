using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class endline : MonoBehaviour
{
    public GameObject pnl;
    public GameObject pnl2;
    [SerializeField] private Text point;
    [SerializeField] private Text best;
    [SerializeField] private Text pointtxt;
    [SerializeField] private Text besttxt;
    public Button btn;
  
    // Start is called before the first frame update
    [SerializeField] public GameObject pl;

    void Start()
    {
        pnl.SetActive(false);
        pnl2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ob" || other.gameObject.tag == "getpoint" || other.gameObject.tag == "e11" )
        {
            //Debug.Log(1);
            pl.SetActive(false);
            pnl.SetActive(true);
            pointtxt.text = "Point "+point.text;
            besttxt.text = best.text;
            pnl2.SetActive(false);
            
        }

    }
    void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Restart()
    {
        StartGame();
    }
    public void quite()
    {
        SceneManager.LoadScene(0);
    }

}
