using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AIPatrol : MonoBehaviour {

	public UnityEngine.AI.NavMeshAgent navMeshAgent;
	public GameObject[] arrWaypoints;

	int arrIndex = 0 ;
	GameObject targetObject;

	// Use this for initialization
	void Start () {
		navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		if (arrWaypoints.Length>0) {
			targetObject = arrWaypoints[arrIndex];
			navMeshAgent.SetDestination( targetObject.transform.position );
		}
	}


	// Update is called once per frame
	void Update () {

		// arrWays
		if (arrWaypoints.Length>0) {
			// actualTarget
			float dist = Vector3.Distance(this.transform.position, targetObject.transform.position);
			if (navMeshAgent!=null) {
				if (dist<0.5f) {
					arrIndex++;
					if (arrIndex>=arrWaypoints.Length) arrIndex = 0;
					targetObject = arrWaypoints[arrIndex];
					navMeshAgent.SetDestination( targetObject.transform.position );
				}
			}
		}
	}
}
