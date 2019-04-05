using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossChange : MonoBehaviour
{
        public void changemenuscene() {
            Application.LoadLevel(MainScreenChange.Cur_Arena);
        }
}
