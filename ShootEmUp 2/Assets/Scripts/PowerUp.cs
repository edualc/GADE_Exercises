using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    float timeStart = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        timeStart = Time.time;
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        transform.Translate(0.2f, Mathf.Cos(Time.time / 2.0f) * 0.05f, 0.0f);
    }
}
