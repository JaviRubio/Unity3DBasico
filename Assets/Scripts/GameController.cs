using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	void OnTriggerEnter (Collider myTrigger) {
		if(myTrigger.gameObject.name == "Sphere"){
			Debug.Log("PartidaFinalizada");
		}
	}
}
