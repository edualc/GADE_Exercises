using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

	private float vx = 0.0f;
	private float vy = 0.0f;
	public float gravity = 1 / 10000;
	public float speed = 0.01f;

	// Use this for initialization
	void Start () {
		transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey ("W")) {
			vx = vx + speed;
		}
		if (Input.GetKey ("S"))  {
			vx = vx - speed;
		}
		if (Input.GetKey ("A")) {
			vy = vy + speed;
		}
		if (Input.GetKey ("D")) {
			vy = vy - speed;
		}

		vy = vy - gravity;
		transform.Translate(vx, vy, 0f);
	}

	private void OnCollisionEnter(Collision c) {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name, LoadSceneMode.Single);
	}
}
