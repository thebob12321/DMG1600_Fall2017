using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOp : MonoBehaviour {

	public string luke = "Jedi";

	public string vader = "Sith";

	public bool leia = true;

	public string darkSide = "Darth Maul";

	public string lightSide = "Obi Wan";

    public int num1 = 10;

    public float num2 = 10.5f;

	// Use this for initialization
	void Start () {

        if(num1 == 10 && num2 == 10.5){
            print("Yes");
        }
        else if( num1 == 10 && num2 == 10){
            print("No");
        }
        else {
            print("Try again");
        }

	// 	if(luke == "Jedi" && vader == "Nanny"){
	// 		print("Vaders yo Nanny!");
	// 	}
	// 	else if (luke == "Jawa" && vader == "Sith"){
	// 		print ("Utini!");
	// 	}		
	// 	else if (luke == "Jedi" && vader == "Sith"){
	// 		print("I am your father!");
	// 	}
	// 	else {
	// 		print("You shouldn't see this");
	// 	}

	// if(leia){
	// 	print("No, there is another.");
	// }
	// else if(!leia){
	// 	print("Hurry!");
	// }
	// else{
	// 	print("Han fired first");
	// }

	if(lightSide == "Obi Wan" || darkSide == "Jar Jar Binks"){
		print("Meeeza Evil Sith Lorda");
	}
	else if (lightSide == "Boba Fett" || darkSide == "Darth Maul"){
		print("As you wish, my master");
	}
	else {
		print("Not the younglings!");
	}


}

	

	
	// Update is called once per frame
	void Update () {
		
	}
}
