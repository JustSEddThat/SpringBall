using UnityEngine;
using System.Collections;

public class MoveBall : MonoBehaviour {

	// Use this for initialization
	private Rigidbody2D rb;
	void Start () 
	{
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (h, v);

		if(Input.GetKey(KeyCode.B))
			rb.AddForce (movement);
	}
}
