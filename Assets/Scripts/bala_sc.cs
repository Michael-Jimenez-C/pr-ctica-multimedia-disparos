using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala_sc : MonoBehaviour
{
	public float dmg;
	
	public void Start(){
		Destroy(gameObject,3f);
	}

	public void OnCollisionEnter(Collision collision){
		
		if(collision.collider.CompareTag("Player") || collision.collider.CompareTag("Bot")){
			collision.gameObject.GetComponent<vida_scr>().vida-=dmg;
		}
		
		if (!collision.collider.CompareTag("Bala")){
			Destroy(gameObject);
		}
	}
}
