using UnityEngine;
using System.Collections;

public class GameWin2 : MonoBehaviour {

	void OnTriggerEnter (Collider myTrigger) {
		if(myTrigger.gameObject.name == "Sphere"){
			Application.LoadLevel("Nivel3");
		}
	}
}
