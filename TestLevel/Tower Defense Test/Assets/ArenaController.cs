using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaController : MonoBehaviour {

    public Transform[] enemies;

    private float nextWaveCount = 15f;
    private float waveCountdown = 5f;
    private float timeBetweenEnemies = 2f;
    private int waveNum = 0;

    public Transform startPoint;


    public GameObject gameOverScreen;

	void Update () {

        if (waveCountdown <= 0f) {
            StartCoroutine(createWave());
            waveCountdown = nextWaveCount;
        }

        waveCountdown = waveCountdown - Time.deltaTime;


        

	}


    IEnumerator createWave() {

        for (int i = 0; i < 5; i++) {
            spawnEnemy();

            yield return new WaitForSeconds(timeBetweenEnemies);
        }


        waveNum++;
    }


    private void spawnEnemy() {
        Instantiate(enemies[waveNum % 2], startPoint.position, startPoint.rotation);
    }

    public void gameOver() {
        gameOverScreen.gameObject.SetActive(true);
    }
}
