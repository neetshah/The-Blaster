using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArenaController : MonoBehaviour
{

    public Transform[] enemies;

    public bool placing;

    public GameObject gameOverScreen, winScreen;

    public float nextWaveCount = 15f;
    private float waveCountdown = 5f;
    public float timeBetweenEnemies = 2f;
    private int waveNum = 0;

    private Vector3 placePoint;

    private int towerToPlace;

    public GameObject[] towers = new GameObject[3];

    public Transform startPoint;

    public Inventory inv;

    void Awake()
    {

        PlayerPrefs.SetInt("Valid", 1);
        PlayerPrefs.SetInt("Main", 0);
        PlayerPrefs.SetInt("Kills", 0);
    }

    void Start()
    {

        towerToPlace = -1;
        placing = false;
        PlayerPrefs.SetInt("GameOver", 0);

    }

    void Update()
    {

        if (waveCountdown <= 0f)
        {
            StartCoroutine(createWave());
            waveCountdown = nextWaveCount;
        }

        waveCountdown = waveCountdown - Time.deltaTime;

        if (PlayerPrefs.GetInt("GameOver") == 1)
        {
            gameOver();
        }

        if (PlayerPrefs.GetInt("Kills") == 20)
        {
            win();
        }

        Debug.Log("Kills: " + PlayerPrefs.GetInt("Kills"));

    }


    IEnumerator createWave()
    {

        for (int i = 0; i < 4; i++)
        {
            spawnEnemy();

            yield return new WaitForSeconds(timeBetweenEnemies);
        }


        waveNum++;
    }


    private void spawnEnemy()
    {
        Instantiate(enemies[waveNum % 2], startPoint.position, startPoint.rotation);
    }

    public void gameOver()
    {
        Debug.Log("Game Over");
        gameOverScreen.SetActive(true);
    }

    public void setPlacePoint(Vector3 p)
    {
        placePoint = p;
    }

    public void setTowerToPlace(int t)
    {
        towerToPlace = t;
        placing = true;
    }

    public int getTowerToPlace()
    {
        return towerToPlace;
    }

    public void placeTower()
    {


        if (PlayerPrefs.GetInt("Valid") == 1)
        {
            Instantiate(towers[towerToPlace], placePoint, transform.rotation);
            inv.removeTower(towerToPlace);
        }

        else
        {
            placing = true;
            return;
        }

        if (towerToPlace == 2)
        {
            PlayerPrefs.SetInt("Main", 1);
        }



        towerToPlace = -1;
        placing = false;
    }

    public void win()
    {
        winScreen.SetActive(true);
        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + 50);
        Time.timeScale = 0;
    }


}
