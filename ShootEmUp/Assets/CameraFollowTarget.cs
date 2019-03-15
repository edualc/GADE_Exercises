using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowTarget : MonoBehaviour
{
    public Transform targetTransform;
    Vector3 tempVector3 = new Vector3();
  
    // Update is called once per frame
    void LateUpdate()
    {
        tempVector3.x = targetTransform.position.x;
        tempVector3.y = this.transform.position.y;
        tempVector3.z = this.transform.position.z;

        this.transform.position = tempVector3;
    }
}
