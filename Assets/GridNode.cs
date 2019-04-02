using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridNode : MonoBehaviour {

    public bool towerPlaced;

    private Renderer r;
    public Color highlight;
    private Color original;

    public ArenaController arena;

    void Start() {
        r = GetComponent<Renderer>();
        original = r.material.color;
        towerPlaced = false;
    }

    void OnMouseDown() {


        if (arena.getTowerToPlace() != -1 && !towerPlaced) {
            r.material.color = highlight;
            arena.setPlacePoint(transform.position);
            arena.placeTower();
            r.material.color = original;
            towerPlaced = true;
        }
        
    }

    void Update() {
        if (arena.placing)
        {
            r.material.color = highlight;
        }

        else {
            r.material.color = original;
        }
    }
}
