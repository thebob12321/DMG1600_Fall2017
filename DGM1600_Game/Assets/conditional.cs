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
// this is to test inputs
		print("STOP!");
		}
		else if(stopLight == "Yellow"){
// you can have as many else if as you want
			print("Slow Down");
		}
		else if(stopLight == "Green"){
			print("Continue Through");
		}
		else{
//only one else and one if
// this can be used to bug test any other unplaned out comes
			print("You're Broken");
		}
	}
}
