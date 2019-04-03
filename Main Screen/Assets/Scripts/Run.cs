using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Run : MonoBehaviour
{
    public void changemenuscene()
    {
        if (MainScreenChange.Cur_Arena == "Earth")
        {
            ClickControl.counter = 0;
            SceneManager.LoadScene("1PickMarsNeptuneMoon", LoadSceneMode.Single);
        }
        else if (MainScreenChange.Cur_Arena == "Mars")
        {
            ClickControl.counter = 0;
            if (Menu.visited == 1)
                SceneManager.LoadScene("2PickNeptuneMoon", LoadSceneMode.Single);
            else if (Menu.visited == 3)
                SceneManager.LoadScene("EndScreen", LoadSceneMode.Single);
            else
            {
                if (Menu.Arena == "Neptune")
                    SceneManager.LoadScene("3PickMoon", LoadSceneMode.Single);
                else
                    SceneManager.LoadScene("3PickNeptune", LoadSceneMode.Single);
            }
        }
        else if (MainScreenChange.Cur_Arena == "Moon")
        {
            ClickControl.counter = 0;
            if (Menu.visited == 1)
                SceneManager.LoadScene("2PickNeptuneMars", LoadSceneMode.Single);
            else if (Menu.visited == 3)
                SceneManager.LoadScene("EndScreen", LoadSceneMode.Single);
            else
            {
                if (Menu.Arena == "Neptune")
                    SceneManager.LoadScene("3PickMars", LoadSceneMode.Single);
                else
                    SceneManager.LoadScene("3PickNeptune", LoadSceneMode.Single);
            }
        }
        else if (MainScreenChange.Cur_Arena == "Neptune")
        {
            ClickControl.counter = 0;
            if (Menu.visited == 1)
                SceneManager.LoadScene("2PickNeptuneMoon", LoadSceneMode.Single);
            else if (Menu.visited == 3)
                SceneManager.LoadScene("EndScreen", LoadSceneMode.Single);
            else
            {
                if (Menu.Arena == "Mars")
                    SceneManager.LoadScene("3PickMoon", LoadSceneMode.Single);
                else
                    SceneManager.LoadScene("3PickMars", LoadSceneMode.Single);
            }
        }

    }
}
