using UnityEngine;
using System.Collections;

public class MenuFunciones : MonoBehaviour {

	public void IniciaNivel1(){
		Application.LoadLevel ("Nivel1");
	}

	public void IniciaNivel2(){
		Application.LoadLevel ("Nivel2");
	}

	public void IniciaNivel3(){
		Application.LoadLevel ("Nivel3");
	}

	public void SalirJuego(){
		Application.Quit ();
	}
}
