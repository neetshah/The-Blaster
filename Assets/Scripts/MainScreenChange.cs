using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScreenChange : MonoBehaviour
{
    public static string[] Arenas = { "Mars", "Neptune", "Moon" };
    public static string Cur_Arena = "Earth";

    public void changemenuscene()
    {
        Application.LoadLevel ("SelectArena");
    }
}
