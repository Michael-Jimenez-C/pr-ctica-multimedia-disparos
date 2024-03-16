using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma_scr : MonoBehaviour
{
	public GameObject bala;
	public GameObject canion;
	public float velocidad_bala;
	public float dmg;
	

	private void Update(){
		if(Input.GetMouseButtonDown(0)){
			GenerarBala();
		}

	}

	public void GenerarBala(){
		GameObject bala_ins = Instantiate(bala,canion.transform.position,canion.transform.rotation);
		bala_ins.GetComponent<bala_sc>().dmg=dmg;
		bala_ins.GetComponent<Rigidbody>().AddForce(canion.transform.forward * velocidad_bala);
	}
}
