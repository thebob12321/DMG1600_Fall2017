using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditional : MonoBehaviour {
	public string stopLight = "Red";

	void start(){
		Main();
	}
	void Main(){
		if(stopLight == "Red"){
		print("STOP! Light is red!");
		}
		else if(stopLight == "Yellow"){
			print("Slow Down");
		}
		else if(stopLight == "Green"){
			print("Continue Through");
		}
		else{
			print("You're Broken");
		}
	}
}
