using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMoney : MonoBehaviour
{

    public Text money, t1, t2;

   
    // Start is called before the first frame update
    void Start()
    {
        money.text = "" + PlayerPrefs.GetInt("Money");
        t1.text = "" + PlayerPrefs.GetInt("tower1Amount");
        t2.text = "" + PlayerPrefs.GetInt("tower2Amount");
    }

    // Update is called once per frame
    void Update()
    {
        money.text = "" + PlayerPrefs.GetInt("Money");
        t1.text = "" + PlayerPrefs.GetInt("tower1Amount");
        t2.text = "" + PlayerPrefs.GetInt("tower2Amount");
    }
}
