using UnityEngine;
using System.Collections;

public class MoveBall : MonoBehaviour {

	public float maxSpeed = 30f;
	private Rigidbody2D rb;
	void Start () 
	{
		rb = this.GetComponent<Rigidbody2D>();
	}
	

	void FixedUpdate () 
	{
		
		if (rb.velocity.magnitude > maxSpeed)
			rb.velocity = rb.velocity.normalized * maxSpeed;
	}

}
