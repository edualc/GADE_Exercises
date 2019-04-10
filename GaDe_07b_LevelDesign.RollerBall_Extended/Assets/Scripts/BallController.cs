using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour {

	public Rigidbody rigidBody;
	public GameObject cameraObj; 
	// Use this for initialization
	void Start () {
	}

	void OnTriggerEnter(Collider other) {
		Element elementObject = other.GetComponent<Element>();
		if (elementObject!=null) {
			// print("element found!" + elementObject.GetElementType());
			if (elementObject.GetElementType().Equals("collect")) {	
				Destroy(other.gameObject);
			}
			if (elementObject.GetElementType ().Equals ("die")) {	
				SceneManager.LoadScene (SceneManager.GetSceneAt (0).name);
			}
		}
	}
	void FixedUpdate() {
		float force = -2.0f;
		if (Input.GetKey("left")) {
			if (rigidBody!=null) {
				rigidBody.AddForce( new Vector3(force, 0.0f, 0.0f ) ) ;
			}
		}
		if (Input.GetKey("right")) {
			if (rigidBody!=null) {
				rigidBody.AddForce( new Vector3(-force, 0.0f, 0.0f ) ) ;
			}
		}
		if (Input.GetKey("up")) {
			if (rigidBody!=null) {
				rigidBody.AddForce( new Vector3(0.0f, 0.0f, -force ) ) ;
			}
		}
		if (Input.GetKey("down")) {
			if (rigidBody!=null) {
				rigidBody.AddForce( new Vector3(0.0f, 0.0f, force ) ) ;
			}
		}
	}
	void Update () {
	
		if (cameraObj != null) {

   cameraObj.transform.position =
		new Vector3 (  transform.position.x, transform.position.y+5.0f, transform.position.z  );

		}

	}
}
