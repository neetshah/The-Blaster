using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inGameMenuController : MonoBehaviour {

    public Button button1;
    public Button button2;
    public Button button3;

    public Text tower1amount, tower2amount, currentGold;

    // Start is called before the first frame update
    void Start() {

        currentGold.text = "Current Gold: " + PlayerPrefs.GetInt("Money");

        if (PlayerPrefs.HasKey("tower1Amount") && PlayerPrefs.HasKey("tower2Amount")) {

            Debug.Log("Shouldn't run");

            tower1amount.text = "" + PlayerPrefs.GetInt("tower1Amount");
            tower2amount.text = "" + PlayerPrefs.GetInt("tower2Amount");
        }

        else {
            tower1amount.text = "" + 1;
            tower2amount.text = "" + 1;
        }
    }

    void Update() {

        if (PlayerPrefs.GetInt("tower1Amount") <= 0) {
            button1.gameObject.SetActive(false);
        }

        if (PlayerPrefs.GetInt("tower2Amount") <= 0)
        {
            button2.gameObject.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Main") == 1)
        {
            button3.gameObject.SetActive(false);
        }

        updateInventoryText();

    }

    public void updateInventoryText() {
        tower1amount.text = "" + PlayerPrefs.GetInt("tower1Amount");
        tower2amount.text = "" + PlayerPrefs.GetInt("tower2Amount");
    }

   
}
