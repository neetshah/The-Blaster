using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System.Linq;


public class ClickControl : MonoBehaviour
{
    static public int counter = 0;
    static public int highcounter = 4;
    public void OnMouseUp()
    {
        counter++;
        Debug.Log("counter: " + counter);
        Debug.Log("highcounter: " + highcounter);
        if (counter % highcounter == 0 && MainScreenChange.Cur_Arena == "Earth")
        {
            SceneManager.LoadScene("BossEarth", LoadSceneMode.Single);
        }
        else if (counter % 4 == 0 && MainScreenChange.Cur_Arena == "Mars")
        {
            SceneManager.LoadScene("BossMars", LoadSceneMode.Single);
        }
        else if (counter % 4 == 0 && MainScreenChange.Cur_Arena == "Moon")
        {
            SceneManager.LoadScene("BossMoon", LoadSceneMode.Single);
        }
        else if (counter % 4 == 0 && MainScreenChange.Cur_Arena == "Neptune")
        {
            SceneManager.LoadScene("BossNeptune", LoadSceneMode.Single);
        }
        else if (counter % 5 == 0 && MainScreenChange.Cur_Arena == "Earth")
        {
            Debug.Log(Menu.Arena);
            counter = 0;
            SceneManager.LoadScene("1PickMarsNeptuneMoon", LoadSceneMode.Single);
        }
        else if (counter % 5 == 0 && MainScreenChange.Cur_Arena == "Mars")
        {
            counter = 0;
            if (Menu.visited == 1)
                SceneManager.LoadScene("2PickNeptuneMoon", LoadSceneMode.Single);
            else if (Menu.visited == 3)
            {
                SceneManager.LoadScene("EndScreen", LoadSceneMode.Single);
            }
            else
            {
                Debug.Log(Menu.visited);
                if (Menu.Arena == "Neptune")
                {
                    MainScreenChange.Cur_Arena = "Moon";
                    SceneManager.LoadScene("3PickMoon", LoadSceneMode.Single);
                }
                else
                {
                    MainScreenChange.Cur_Arena = "Neptune";
                    SceneManager.LoadScene("3PickNeptune", LoadSceneMode.Single);
                }
            }
        }
        else if (counter % 5 == 0 && MainScreenChange.Cur_Arena == "Moon")
        {
            counter = 0;
            if (Menu.visited == 1)
                SceneManager.LoadScene("2PickNeptuneMars", LoadSceneMode.Single);
            else if (Menu.visited == 3)
            {
                SceneManager.LoadScene("EndScreen", LoadSceneMode.Single);
            }
            else
            {
                Debug.Log(Menu.visited);
                if (Menu.Arena == "Neptune")
                {
                    MainScreenChange.Cur_Arena = "Mars";
                    SceneManager.LoadScene("3PickMars", LoadSceneMode.Single);
                }
                else
                {
                    MainScreenChange.Cur_Arena = "Neptune";
                    SceneManager.LoadScene("3PickNeptune", LoadSceneMode.Single);
                }
            }
        }
        else if (counter % 5 == 0 && MainScreenChange.Cur_Arena == "Neptune")
        {
            counter = 0;
            if (Menu.visited == 1)
                SceneManager.LoadScene("2PickMarsMoon", LoadSceneMode.Single);
            else if (Menu.visited == 3)
            {
                SceneManager.LoadScene("EndScreen", LoadSceneMode.Single);
            }
            else
            {
                Debug.Log(Menu.visited);
                if (Menu.Arena == "Mars")
                {
                    MainScreenChange.Cur_Arena = "Moon";
                    SceneManager.LoadScene("3PickMoon", LoadSceneMode.Single);
                }
                else
                {
                    MainScreenChange.Cur_Arena = "Mars";
                    SceneManager.LoadScene("3PickMars", LoadSceneMode.Single);
                }
            }
        }
        else
        {
            SceneManager.LoadScene("MainScreen", LoadSceneMode.Single);
        }
    }
}