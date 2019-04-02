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

    public bool compareCost(int cost) {
        return PlayerPrefs.GetInt("Money") > cost;
    }
}
