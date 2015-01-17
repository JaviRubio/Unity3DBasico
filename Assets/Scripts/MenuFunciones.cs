using UnityEngine;
using System.Collections;

public class MenuFunciones : MonoBehaviour {

	public void NuevaPartida(){
		Application.LoadLevel ("Nivel1");
	}

	public void SalirJuego(){
		Application.Quit ();
	}
}
