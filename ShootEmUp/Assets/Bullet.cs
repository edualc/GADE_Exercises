using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float vx = 0.3f;
    private Rigidbody rigidBody;
    private float timeToLive = 2.0f;
    private Type type;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        type = GetComponent<Type>();
        Destroy(this.gameObject, timeToLive);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = transform.position + new Vector3(vx, 0.0f, 0.0f);
        rigidBody.MovePosition(pos);
    }

    private void OnTriggerEnter(Collider other)
    {
        Type typeObject = other.GetComponent<Type>();
        if (typeObject != null)
        {
            // TODO: Handle different bullet types
            switch (typeObject.type)
            {
                case Type.objectTypes.background:
                    Destroy(this.gameObject);
                    break;
                case Type.objectTypes.playerBullet:
                    Destroy(this.gameObject);
                    break;
                case Type.objectTypes.enemyBullet:
                    Destroy(other.gameObject);
                    Destroy(this.gameObject);
                    break;
                case Type.objectTypes.enemy:
                    Destroy(other.gameObject);
                    Destroy(this.gameObject);
                    break;
                case Type.objectTypes.player:
                    break;
                default:
                    break;
            }
        } else
        {
            print("no type found");
        }
    }
}
