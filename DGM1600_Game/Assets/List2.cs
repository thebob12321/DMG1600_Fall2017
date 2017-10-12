using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		List<FirstOrder> Pokemon = new List<FirstOrder>();

		Pokemon.Add(new FirstOrder("Bulbasaur",1));
		Pokemon.Add(new FirstOrder("Ivysaur",2));
		Pokemon.Add(new FirstOrder("Venusaur",3));
		Pokemon.Add(new FirstOrder("Pikachu",25));

		Pokemon.Sort(); 

		foreach(FirstOrder poke in Pokemon){
			print(poke.name + " " + poke.power);
		}
	}
	
	
	// Update is called once per frame
	void Update () {
		
	}
}
