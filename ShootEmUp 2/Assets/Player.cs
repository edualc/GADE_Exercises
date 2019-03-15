using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private float vx = 0.25f;
    private float vy = 0.25f;
    private Rigidbody rigidBody;
    private float attackCooldown = 0.4f;
    private float timeStamp;
    public Bullet bullet;
    private float scrollSpeedX = 0.3f;

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
            if (Input.GetKey(KeyCode.Space))
            {
                Instantiate(bullet, this.transform.position + new Vector3(0.5f, 0.0f, 0.0f), Quaternion.identity);
                timeStamp = Time.time + attackCooldown;
            }
        }
    }

    void handleMovement()
    {
        Vector3 pos = new Vector3(transform.position.x + scrollSpeedX, transform.position.y, transform.position.z);

        if (Input.GetKey(KeyCode.W)) {
            pos.y = pos.y + vy;
        }
        if (Input.GetKey(KeyCode.S)) {
            pos.y = pos.y - vy;
        }
        if (Input.GetKey(KeyCode.A)) {
            pos.x = pos.x - vx;
        }
        if (Input.GetKey(KeyCode.D)) {
            pos.x = pos.x + vx;
        }

        pos.y = Mathf.Clamp(pos.y, -4.0f, 6.0f);

        rigidBody.MovePosition(pos);
    }

    private void OnTriggerEnter(Collider other)
    {
        Type otherType = other.GetComponent<Type>();

        if (otherType != null) {
            if (otherType.type == Type.objectTypes.enemy) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            if (otherType.type == Type.objectTypes.background) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

}
