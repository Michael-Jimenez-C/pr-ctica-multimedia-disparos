using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida_scr : MonoBehaviour
{
	public float vida=100;

	public void Update(){
		if (vida <=0){
			if(gameObject.CompareTag("Player")){
				Debug.Log("Game over");
			}else if(gameObject.CompareTag("Bot")){
				Destroy(gameObject);
			}
		}
	}
}
