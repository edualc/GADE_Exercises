using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinusEnemy : Enemy
{
    float timeStart = 0.0f;

    // Start is called before the first frame update
    public void Start()
    {
        timeStart = Time.time;
    }

    public void Update()
    {
        
    }

    public override void Behaviour()
    {
        transform.Translate(0.2f, Mathf.Cos(Time.time) * 0.05f, 0.0f);
    }
}
