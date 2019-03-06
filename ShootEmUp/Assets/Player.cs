using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float vx = 0.25f;
    private float vy = 0.25f;
    private Rigidbody rigidBody;
    private float attackCooldown = 2.0f;
    private float timeStamp;
    public Bullet bullet;

    // Start is called before the first frame update
    void Start()
    {
        timeStamp = Time.time;
        rigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        handleAttack();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        handleMovement();
    }

    void handleAttack()
    {
        if (timeStamp <= Time.time)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(bullet, this.transform.position + new Vector3(1.0f, 0.0f, 0.0f), Quaternion.identity);
                timeStamp = Time.time + attackCooldown;
            }
        }

        

    }

    void handleMovement()
    {
        Vector3 pos = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        if (Input.GetKey(KeyCode.W))
        {
            pos.y = pos.y + vy;
        }
        if (Input.GetKey(KeyCode.S))
        {
            pos.y = pos.y - vy;
        }
        if (Input.GetKey(KeyCode.A))
        {
            pos.x = pos.x - vx;
        }
        if (Input.GetKey(KeyCode.D))
        {
            pos.x = pos.x + vx;
        }

        rigidBody.MovePosition(pos);
    }
}
