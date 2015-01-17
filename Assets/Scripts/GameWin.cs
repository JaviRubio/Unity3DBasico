using UnityEngine;
using System.Collections;

public class GameWin : MonoBehaviour {

	void OnTriggerEnter (Collider myTrigger) {
		if(myTrigger.gameObject.name == "Sphere"){
			Application.LoadLevel("Nivel2");
		}
	}
}
