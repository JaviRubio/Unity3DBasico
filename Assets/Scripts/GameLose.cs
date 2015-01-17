using UnityEngine;
using System.Collections;

public class GameLose : MonoBehaviour {
	
	void OnTriggerEnter (Collider myTrigger) {
		if(myTrigger.gameObject.name == "Sphere"){
			Application.LoadLevel("Menu");
		}
	}
}