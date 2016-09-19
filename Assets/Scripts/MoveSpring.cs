using UnityEngine;
using System.Collections;

public class MoveSpring : MonoBehaviour {


	void Start () 
	{
		
		gameObject.GetComponent<MoveSpring> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{

		Vector3 movement = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"));
		transform.position += movement;
	}



}
