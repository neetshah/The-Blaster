using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed = 10f;
    private Transform currentCheckpoint;
    private int checkpointIndex = 0;

    public ArenaController arena;

	void Start () {
        currentCheckpoint = Checkpoints.points[0];
    }

    // Update is called once per frame
    void Update () {
        Vector3 direction = currentCheckpoint.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime , Space.World);

        if (Vector3.Distance(transform.position, currentCheckpoint.position) <= 0.2f) {
            incrementCheckpoint();
        }
	}

    private void incrementCheckpoint() {

        if (checkpointIndex >= Checkpoints.points.Length - 1) {

            Destroy(gameObject);

            //ArenaController.gameOverScreen.SetActive(true);

            arena.gameOver();

            return;
        }

        checkpointIndex++;
        currentCheckpoint = Checkpoints.points[checkpointIndex];
    }
}
