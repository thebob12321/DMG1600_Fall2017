using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidFun : MonoBehaviour {

	public int laserBlast;

	// Use this for initialization
	void Start () {
		DeathStar(laserBlast);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void DeathStar(int vent){
		print("That's no moon, that's a space station!");
		
		if(vent == 1){
			print("Fail");
		}
		else if (vent ==2){
			print("Close");
		}
		else {
			print("Direct Hit!");
		}
		


		// print(vent);

		// if (vent >= 3){
		// 	print("Boom");
		// }
		// else {
		// 	print("Miss");
		// }
	
	}
}
