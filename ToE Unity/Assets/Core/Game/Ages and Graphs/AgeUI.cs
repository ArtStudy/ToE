using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AgeUI : MonoBehaviour
{
    public Age Age;
    public List<GameObject> Levels;
    public SortLevels sortLevels;
    private GameObject instLevel;
    public Vector3 levelPos;

    void Start ()
    {
        sortLevels = new SortLevels();
        LoadLevels();
	}
	
	void Update ()
    {
		
	}

    void LoadLevels()
    {     
        for (int i = 0; i < Levels.Count; i++) 
        {
            Instantiate(Levels[i]);           
            Levels[i].transform.position = sortLevels.randomFirstLevelPos(this.transform.localScale.x / 2);
        }
        //sortLevels.StartSorting();
    }

}
