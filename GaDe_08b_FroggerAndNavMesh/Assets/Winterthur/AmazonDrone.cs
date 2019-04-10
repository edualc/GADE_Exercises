using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmazonDrone : MonoBehaviour
{
  public UnityEngine.AI.NavMeshAgent navMeshAgent;
  public GameObject[] controlPoints;
  int controlPointIndex = 0;
  
  // Start is called before the first frame update
  void Start()
  {
    navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();   
  }

  // Update is called once per frame
  void Update()
  {
    if (navMeshAgent != null) {
      Vector3 targetPosition = controlPoints[controlPointIndex].transform.position;
      navMeshAgent.SetDestination(controlPoints[controlPointIndex].transform.position);

      float dist = Vector3.Distance(this.transform.position, targetPosition);

      print(dist);

      if (dist < 2.5f) {
        controlPointIndex++;
        controlPointIndex = controlPointIndex % controlPoints.Length  ;
      }
    }
  }
}
