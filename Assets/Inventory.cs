using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private static int[] towers = new int[2];

    public inGameMenuController menu;

    void Start() {

        PlayerPrefs.DeleteAll();

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
        PlayerPrefs.SetInt("tower1Amount", towers[type]);
    }

    public void removeTower(int type) {

        towers[type]--;

        if (type == 0) {
            PlayerPrefs.SetInt("tower1Amount", towers[type]);
        }

        else if (type == 1) {
            PlayerPrefs.SetInt("tower2Amount", towers[type]);
        }
        

    }


}
