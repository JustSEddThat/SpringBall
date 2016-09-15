using UnityEngine;
using System.Collections;

public class MoveBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 movement = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"));
		if(Input.GetKey(KeyCode.Alpha1))
			transform.position += movement;



	}
}
