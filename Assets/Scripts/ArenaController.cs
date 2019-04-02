﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArenaController : MonoBehaviour {

    public Transform[] enemies;

    public bool placing;

    private float nextWaveCount = 15f;
    private float waveCountdown = 5f;
    private float timeBetweenEnemies = 2f;
    private int waveNum = 0;

    private Vector3 placePoint;

    private int towerToPlace;

    public GameObject[] towers = new GameObject[2];

    public Transform startPoint;

    public Inventory inv;

    void Start() {

        towerToPlace = -1;
        placing = false;
    }

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
    }

    public void setPlacePoint(Vector3 p) {
        placePoint = p;
    }

    public void setTowerToPlace(int t) {
        towerToPlace = t;
        placing = true;
        Debug.Log(PlayerPrefs.GetInt("tower2Amount"));
    }

    public int getTowerToPlace() {
        return towerToPlace;
    }

    public void placeTower() {

        Instantiate(towers[towerToPlace], placePoint, transform.rotation);

        inv.removeTower(towerToPlace);
        

        towerToPlace = -1;
        placing = false;
    }

    
}
