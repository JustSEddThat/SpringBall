using UnityEngine;
using System.Collections;

public class MoveBall : MonoBehaviour {

	public float maxSpeed = 30f;
	private Rigidbody2D rb;
	void Start () 
	{
		rb = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		/*
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (h, v);
		transform.position += movement; */
		if (rb.velocity.magnitude > maxSpeed)
			rb.velocity = rb.velocity.normalized * maxSpeed;
	}

}
