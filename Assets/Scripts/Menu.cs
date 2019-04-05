using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    static public int visited = 0;
    static public string[] Arena = new string[2];

    public void changemenuscene(string NewScene)
    {
        Arena[visited] = NewScene;
        visited++;
        MainScreenChange.Cur_Arena = NewScene;
        Application.LoadLevel(NewScene);
    }
}
