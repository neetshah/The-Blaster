using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inGameMenuController : MonoBehaviour {

    public Button button1;
    public Button button2;

    // Start is called before the first frame update
    void Start() {

        /*if (PlayerPrefs.HasKey("tower1Amount") && PlayerPrefs.HasKey("tower2Amount")) {

            Debug.Log("Shouldn't run");

            tower1amount.text = "" + PlayerPrefs.GetInt("tower1Amount");
            tower2amount.text = "" + PlayerPrefs.GetInt("tower2Amount");
        }

        else {
            tower1amount.text = "" + 1;
            tower2amount.text = "" + 1;
        }*/
    }

    void Update() {

        if (PlayerPrefs.GetInt("tower1Amount") <= 0) {
            button1.gameObject.SetActive(false);
        }

        if (PlayerPrefs.GetInt("tower2Amount") <= 0)
        {
            button2.gameObject.SetActive(false);
        }
    }

   
}
