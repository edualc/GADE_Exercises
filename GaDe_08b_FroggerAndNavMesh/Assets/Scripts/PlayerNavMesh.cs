using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerNavMesh : MonoBehaviour {

	public Camera cam;
	public UnityEngine.AI.NavMeshAgent navMeshAgent;

	// Use this for initialization
	void Start () {
		cam = Camera.main;
		navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		
	}

	void OnTriggerEnter(Collider other) {

			Destroy(other.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown( KeyCode.Mouse0)) {
			Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition ) ;
			RaycastHit hit;
			if (Physics.Raycast( ray, out hit )) {
				navMeshAgent.SetDestination( hit. point );
			}
		}
	}
}
