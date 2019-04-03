using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// namespace CompleteProject  -- namespace that other classes are using in project tutorial
public class towerButton : MonoBehaviour
{

    //public Player player;         no player shooting or weapon Number present
    public int towerNumber;

    public Text name;
    public Text cost;
    public Text description;

    private AudioSource source; // plays a sound when selected

    // Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();
        SetButton();
    }

    void SetButton()
    {
        //name.text = player.towers[towerNumber].name;
        //cost.text = "$" + player.towers[towerNumber].cost;
        //description.text = player.towers[towerNumber].description;
    }

    public void OnClick()
    {
        if (false)
        {

        }
        //if (ScoreManager.score >= player.towers[towerNumber].cost)
        //{

        //    ScoreManager.score -= player.towers[towerNumber].cost;
        //    player.currentTower = towerNumber;

        //}

        else
        {
            source.Play();
        }
    }
}

