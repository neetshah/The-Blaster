using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private static int[] towers = new int[2];

    public inGameMenuController menu;

    private int[] tCosts = {50, 100};
    private int[] uCosts = {25, 25};

    void Start() {

        if (PlayerPrefs.HasKey("tower1Amount")) {
            towers[0] = PlayerPrefs.GetInt("tower1Amount");
        }

        else {
            PlayerPrefs.SetInt("tower1Amount", 1);
            towers[0] = 1;
        }

        if (PlayerPrefs.HasKey("tower2Amount"))
        {
            towers[1] = PlayerPrefs.GetInt("tower2Amount");
        }

        else
        {
            PlayerPrefs.SetInt("tower2Amount", 1);
            towers[1] = 1;
        }
    }

    public int getAmountTower1() {
        return towers[0];
    }

    public void addTower(int type) {
        towers[type]++;

        if (type == 0 && PlayerPrefs.GetInt("Money") >= tCosts[0]) {
            PlayerPrefs.SetInt("tower1Amount", towers[0]);
        }


        else if (type == 1 && PlayerPrefs.GetInt("Money") >= tCosts[0])
        {
            PlayerPrefs.SetInt("tower2Amount", towers[1]);
        }
    }

    public void upgradeTower(int t) {

        if (!PlayerPrefs.HasKey("Tower1Upgrade")) {
            PlayerPrefs.SetInt("Tower1Upgrade", 0);
        }

        if (!PlayerPrefs.HasKey("Tower2Upgrade"))
        {
            PlayerPrefs.SetInt("Tower2Upgrade", 0);
        }

        if (t == 0 && PlayerPrefs.GetInt("Money") >= uCosts[0])
        {
            PlayerPrefs.SetInt("Tower1Upgrade", PlayerPrefs.GetInt("Tower1Upgrade") + 1);
        }

        else if (t == 1 && PlayerPrefs.GetInt("Money") >= uCosts[1]) {
            PlayerPrefs.SetInt("Tower2Upgrade", PlayerPrefs.GetInt("Tower2Upgrade") + 1);
        }
    }

    public void upgradeMain() {

        if (!PlayerPrefs.HasKey("MainUpgrade"))
        {
            PlayerPrefs.SetInt("MainUpgrade", 0);
        }

        if (PlayerPrefs.GetInt("Money") >= 100)
        {
            PlayerPrefs.SetInt("MainUpgrade", PlayerPrefs.GetInt("MainUpgrade") + 1);
        }
    }

    public void removeTower(int type) {

        if (type != 2) {
            towers[type]--;

            if (type == 0)
            {
                PlayerPrefs.SetInt("tower1Amount", towers[type]);
            }

            else if (type == 1)
            {
                PlayerPrefs.SetInt("tower2Amount", towers[type]);
            }
        }
        

    }


}
