using UnityEngine;
using System.Collections;

public class PlatformController : MonoBehaviour {

	public float velocidadX;
	public float velocidadZ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float rotacionX = Input.GetAxis("Horizontal") * velocidadX*-1;
		float rotationZ = Input.GetAxis("Vertical") * velocidadZ*-1;
		transform.Rotate(rotacionX*Time.deltaTime, 0, rotationZ*Time.deltaTime);
	}
}
