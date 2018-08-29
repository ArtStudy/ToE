using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortLevels {

    public float levelSpeed = 10.0f; 


    public SortLevels()
    {

    }

    public void StartSorting()
    {

    }

    public Vector3 randomFirstLevelPos(float r)
    {
        double x, y, z;
        x = UnityEngine.Random.Range(0, r);
        y = UnityEngine.Random.Range(0, (float)Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x, 2)));
        z = Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x, 2) - Math.Pow(y, 2));
        Vector3 pos = new Vector3((float)x, (float)y, (float)z);
        return  pos;
    }

}
