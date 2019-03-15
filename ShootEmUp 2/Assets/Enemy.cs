using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //public float vx = -0.15f;
    //private Rigidbody rigidBody;
    //private float attackCooldown = 2.0f;
    //private float timeStamp;
    private float timeToLive = 25.0f;
    //public Bullet bullet;
    //private float scrollSpeedX = 0.3f;

    // Start is called before the first frame update
    public void Start()
    {
        //timeStamp = Time.time + attackCooldown * Random.Range(0.5f, 3.0f);
        //rigidBody = GetComponent<Rigidbody>();
        Destroy(this.gameObject, timeToLive);
    }

    public void Update()
    {
        //handleAttack();
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        //handleMovement();
        Behaviour();
    }

    public virtual void Behaviour()
    {
        // define in subclasses
    }

    //void handleAttack()
    //{
    //    if (timeStamp <= Time.time) {
    //        Instantiate(bullet, this.transform.position - new Vector3(0.5f, 0.0f, 0.0f), Quaternion.identity);
    //        timeStamp = Time.time + attackCooldown * Random.Range(0.5f, 3.0f);
    //    }
    //}

    //void handleMovement()
    //{
    //    Vector3 pos = new Vector3(transform.position.x + scrollSpeedX, transform.position.y, transform.position.z);
    //    pos.x += vx;

    //    rigidBody.MovePosition(pos);
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    Type otherType = other.GetComponent<Type>();

    //    if (otherType != null) {
    //        if (otherType.type == Type.objectTypes.background) {
    //            Destroy(this.gameObject);
    //        }
    //    }
    //}
}
