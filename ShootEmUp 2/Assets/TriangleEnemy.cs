using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleEnemy : Enemy
{
    float timeStart = 0.0f;

    // Start is called before the first frame update
    public void Start()
    {
        timeStart = Time.time;
    }

    public override void Behaviour()
    {

        float timeDiff = Time.time - timeStart;
        if (timeDiff < 1.0f) {
            transform.Translate(-0.1f, 0.1f, 0.0f);
        } else {
            transform.Translate(-0.1f, -0.1f, 0.0f);
        }

        if (timeDiff > 2.0f) {
            timeStart = Time.time;
        }
    }
}
