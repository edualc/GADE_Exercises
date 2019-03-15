using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinusEnemy : Enemy
{
    float timeStart = 0.0f;

    // Start is called before the first frame update
    public void Start()
    {
        base.Start();
        timeStart = Time.time;
    }

    public void Update()
    {
        base.Update();
    }

    public void FixedUpdate()
    {
        base.FixedUpdate();
    }

    public override void Behaviour()
    {
        base.Behaviour();
        float timeDiff = Time.time - timeStart;

        transform.Translate(0.0f, Mathf.Cos(timeDiff) * 0.1f, 0.0f);
    }
}
