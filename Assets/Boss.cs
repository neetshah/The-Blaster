using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform target;
    public float range = 5f;
    public string Turrets = "Turret";

    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.1f);
    }

    void UpdateTarget()
    {
        GameObject[] turrets = GameObject.FindGameObjectsWithTag(Turrets);
        //GameObject[] disabled = new GameObject[20];
        List<GameObject> disabled = new List<GameObject>();
        int len = 0;if (turrets == null)
            Debug.Log("Is Null");
        foreach (GameObject turret in turrets)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, turret.transform.position);
            if (distanceToEnemy < range)
            {
                disabled.Add(turret);
                turret.SetActive(false);
            }
            else
            {
                turret.SetActive(true);
            }
        }

        foreach (GameObject turret in disabled)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, turret.transform.position);
            Debug.Log("Distance: "+distanceToEnemy);
            if (distanceToEnemy > range)
            {
                turret.SetActive(true);
                Debug.Log("SET TRUE");
                disabled.Remove(turret);
            }
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
