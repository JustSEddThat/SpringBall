using UnityEngine;
using System.Collections;

public class MoveSpring : MonoBehaviour {


	void Start () 
	{
		gameObject.GetComponent<MoveSpring> ().enabled = false;

	}

	void Update () 
	{
		Vector3 movement = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"));
		transform.position += movement;
		transform.position = new Vector2 (Mathf.Clamp (transform.position.x, -11f, 11f), Mathf.Clamp(transform.position.y, -5, 5));
	}




}
