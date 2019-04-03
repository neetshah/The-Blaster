using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    int counter = 0;

    void changescreen()
    {
        if (Input.GetMouseButtonDown(0)){
            counter++;
            if (counter % 4 == 1)
            {
                Application.LoadLevel("Neptune");
            }
        }
    }
}
