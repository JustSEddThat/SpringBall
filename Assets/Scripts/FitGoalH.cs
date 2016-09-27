using UnityEngine;
using System.Collections;

public class FitGoalH : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		other.GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezePositionY;
	}
}
