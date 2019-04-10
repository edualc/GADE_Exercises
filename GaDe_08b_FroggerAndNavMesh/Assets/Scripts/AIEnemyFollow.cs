using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AIEnemyFollow : MonoBehaviour {

	public UnityEngine.AI.NavMeshAgent navMeshAgent;

	// Use this for initialization
	void Start () {
		navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
	}

	// Update is called once per frame
	void Update () {
		GameObject player = GameObject.Find("Player")	;
		if (navMeshAgent!=null) {
			navMeshAgent.SetDestination( player.transform.position );
		}
	}
}
