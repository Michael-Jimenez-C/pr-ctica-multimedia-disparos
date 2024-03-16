using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma_scr : MonoBehaviour
{
	public GameObject bala;
	public GameObject canion;
	public float velocidad_bala;
	public float dmg;
	public bool es_jugador;
	public float tiempo_disparo=2f;
	public float tiempo_espera;

	private void Update(){
		if (es_jugador){
			if(Input.GetButtonDown("Fire1")){
				GenerarBala();
			}
		}else{
			tiempo_espera-=Time.deltaTime;
			if(tiempo_espera<1){
				GenerarBala();
				tiempo_espera=tiempo_disparo;
			}
		}

	}

	public void GenerarBala(){
		GameObject bala_ins = Instantiate(bala,canion.transform.position,canion.transform.rotation);
		bala_ins.GetComponent<bala_sc>().dmg=dmg;
		bala_ins.GetComponent<Rigidbody>().AddForce(canion.transform.forward * velocidad_bala);
	}
}
