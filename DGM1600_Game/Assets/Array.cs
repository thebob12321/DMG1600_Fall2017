using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public GameObject[] inventory = new GameObject [12];
// // 12 is 12, 0-11 total items
// inventory [0] = "Bazooka";
// inventory [11] = "Fist";


public class Array : MonoBehaviour {
	public string[] heros = new string[9];

	// Use this for initialization
	void Start () {
		heros[0] = "Ironman";
		heros[1] = "BlackPanther";
		heros[2] = "Thor";
		heros[3] = "Hulk";
		heros[4] = "CaptainAmarica";
		heros[5] = "Hawkeye";

		print(heros[2]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
