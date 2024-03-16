using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class vida_scr : MonoBehaviour
{
	public float vida=100;
	public TextMeshProUGUI text_mesh;
	public void Update(){
		text_mesh.text = "Vida: "+vida.ToString();
		if (vida <=0){
			if(gameObject.CompareTag("Player")){
				Debug.Log("Game over");
			}else if(gameObject.CompareTag("Bot")){
				Destroy(gameObject);
			}
		}
	}
}
