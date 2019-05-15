using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sunglasses : MonoBehaviour
{

  public Animator animator;
  private float cooldownTime;

  // Start is called before the first frame update
  void Start()
  {    
    animator = GetComponent<Animator>();
  }

  // Update is called once per frame
  void Update()
  {
    RaycastHit hit;
    if (Input.GetMouseButtonDown(0)) 
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
          AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
          print(hit.collider.gameObject.name);

          animator.SetBool("IsShakingHead", true);
          cooldownTime = 1000;
        }
    } else {
      cooldownTime--;
      
      if (cooldownTime <= 0) {
        animator.SetBool("IsShakingHead", false);
      }
    }
  }
}
