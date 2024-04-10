using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AI_bot : MonoBehaviour
{
	public NavMeshAgent agente;
	public GameObject player;
	public float speed = 150;
	public void Update(){
		agente.destination=player.transform.position;
	}
}
