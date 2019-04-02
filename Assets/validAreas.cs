using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class validAreas : MonoBehaviour
{
    public static GridNode[] points;

    void Awake()
    {
        points = new GridNode[transform.childCount];

        
    }
}
