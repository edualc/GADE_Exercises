using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public float vx = 0.0f;
    private Rigidbody rigidBody;
    private float timeToLive = 5.0f;
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
        Type otherType = other.GetComponent<Type>();
        print("OnTriggerEnter " + type.type + " -> " + otherType.type);

        if (otherType != null) {
            if (type.type == Type.objectTypes.playerBullet) {
                switch (otherType.type) {
                    case Type.objectTypes.background:
                        Destroy(this.gameObject);
                        break;
                    case Type.objectTypes.enemy:
                    case Type.objectTypes.enemyBullet:
                        Destroy(other.gameObject);
                        Destroy(this.gameObject);
                        break;
                    default:
                        break;
                }
            }

            if (type.type == Type.objectTypes.enemyBullet) {
                switch (otherType.type) {
                    case Type.objectTypes.background:
                        Destroy(this.gameObject);
                        break;
                    case Type.objectTypes.player:
                        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                        break;
                    case Type.objectTypes.playerBullet:
                        Destroy(other.gameObject);
                        Destroy(this.gameObject);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
