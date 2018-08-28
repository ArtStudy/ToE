using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Core.Ages;
using Assets.Core.Volutes;

public class FirstAge : MonoBehaviour, IAges
{
	void Start ()
    {
        this.Name = "Myself Age";
        this.ID = 1;
	}

	void Update ()
    {
		
	}

    public string Name { get; set; }
    public int ID { get; set; }
    public Money Price { get; set; }
    IGraph Graph { get; set; }
    public bool Availability { get; set; }


}
