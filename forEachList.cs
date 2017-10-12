﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forEachList : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		List<FirstOrder> badguys = new List<FirstOrder>();

		badguys.Add(new FirstOrder("Snoke",1000));
		badguys.Add(new FirstOrder("General Hux",20));
		badguys.Add(new FirstOrder("Kylo Ren",400));
		badguys.Add(new FirstOrder("Captian Phasma",150));

		badguys.Sort(); 

		foreach(FirstOrder guy in badguys){
			print(guy.name + " " + guy.power);
		}
	}



	
	// Update is called once per frame
	void Update () {
		
	}
}
