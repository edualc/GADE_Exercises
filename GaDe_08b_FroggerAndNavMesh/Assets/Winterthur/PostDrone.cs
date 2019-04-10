using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostDrone : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent navMeshAgent;
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
      cam = Camera.main;
      navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();   
    }

    // Update is called once per frame
    void Update()
    {

      if (navMeshAgent != null) {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
          GameObject player = GameObject.Find("Player");
          // navMeshAgent.SetDestination( player.transform.position );
          
          Ray ray = cam.ScreenPointToRay(Input.mousePosition);
          RaycastHit hit;
          if (Physics.Raycast( ray, out hit)) {
            navMeshAgent.SetDestination(hit.point);
          }
        }
      }
    }
}
