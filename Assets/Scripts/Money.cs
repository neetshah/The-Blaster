using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{

    public void addMoney(int amount) {
        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + amount);
    }

    public void subtractMoney(int amount) {
        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - amount);
    }

    public void compareCost(int cost) {
        if (PlayerPrefs.GetInt("Money") >= cost) {
            subtractMoney(cost);
        }
    }
}
