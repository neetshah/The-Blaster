using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopChange : MonoBehaviour
{
    public void changemenuscene()
    {
        Application.LoadLevel(MainScreenChange.Cur_Arena);
    }
}
