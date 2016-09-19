using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	// Place Springs 1 by 1
		// move one spring-press enter-shut off that spring-
	//press enter
	//Game plays
	public GameObject spring1, spring2, spring3, ball;
	public bool isOneOn = false;

	void Start () 
	{
		
		ball.GetComponent<Rigidbody2D> ().isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//box1
		if (Input.GetButtonDown ("Fire1")&& isOneOn == false)
		{
			spring1.GetComponent<MoveSpring> ().enabled = true;
			isOneOn = true;
		}
		else if (Input.GetButtonDown ("Fire1") && spring1.GetComponent<MoveSpring> ().enabled) 
		{
			spring1.GetComponent<MoveSpring> ().enabled = false;
			isOneOn = false;
		}
			
		//box2
		if (Input.GetButtonDown ("Fire2") && isOneOn == false) 
		{
			spring2.GetComponent<MoveSpring> ().enabled = true;
			isOneOn = true;
		}	
		else if (Input.GetButtonDown ("Fire2") && spring2.GetComponent<MoveSpring> ().enabled) 
		{
			spring2.GetComponent<MoveSpring> ().enabled = false;
			isOneOn = false;
		}
			
		//box3
		if (Input.GetButtonDown ("Fire3") && isOneOn == false) 
		{
			spring3.GetComponent<MoveSpring> ().enabled = true;
			isOneOn = true;
		}
		else if (Input.GetButtonDown ("Fire3") && spring3.GetComponent<MoveSpring> ().enabled) 
		{
			spring3.GetComponent<MoveSpring> ().enabled = false;
			isOneOn = false;
		}
			


		if (isOneOn == false && Input.GetButtonDown ("Submit"))
			ball.GetComponent<Rigidbody2D> ().isKinematic = false;


	}
}
