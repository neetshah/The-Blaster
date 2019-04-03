using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    static public int visited = 0;
    static public string Arena;

    public void changemenuscene(string NewScene)
    {
        Arena = NewScene;
        visited++;
        MainScreenChange.Cur_Arena = NewScene;
        Application.LoadLevel("MainScreen");
    }
}
