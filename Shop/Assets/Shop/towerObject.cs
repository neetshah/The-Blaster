using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TowerObject : ScriptableObject
{
    public string towerName = "Weapon Name Here";
    public int cost = 50;
    public string description;

    public int damage = 10;
    public int fireRate = 100;     // defined in terms of rate of firing bullets per second

}
