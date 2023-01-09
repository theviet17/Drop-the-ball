using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textbonus : MonoBehaviour
{
    public TMP_Text textbn;
    float bn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       bn = PlayerPrefs.GetFloat("textbonus");
        textbn.text = "Bonus +" + bn;
    }
}
