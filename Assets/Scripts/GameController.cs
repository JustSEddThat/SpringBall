using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameController : MonoBehaviour {

	public GameObject spring1, spring2, spring3, ball, UI, button;
	Text gameNote;
	public bool isOneOn = false, isInPlay = false;

	Vector2 initialPos;

	void Start () 
	{
		
		initialPos = ball.transform.position;
		ball.GetComponent<Rigidbody2D> ().isKinematic = true;
		gameNote = UI.GetComponentInChildren<Text>();
		button.SetActive (false);

	}



	void Update ()
	{
		//box1
		if (Input.GetButtonDown ("Fire1")&& isOneOn == false && !isInPlay)
		{
			spring1.GetComponent<MoveSpring> ().enabled = true;
			ShiftGameNoteMessage (spring1);
			isOneOn = true;
		}
		else if (Input.GetButtonDown ("Fire1") && spring1.GetComponent<MoveSpring> ().enabled) 
		{
			spring1.GetComponent<MoveSpring> ().enabled = false;
			isOneOn = false;
			ShiftGameNoteMessage ();
		}
			
		//box2
		if (Input.GetButtonDown ("Fire2") && isOneOn == false && !isInPlay) 
		{
			spring2.GetComponent<MoveSpring> ().enabled = true;
			ShiftGameNoteMessage (spring2);
			isOneOn = true;
		}	
		else if (Input.GetButtonDown ("Fire2") && spring2.GetComponent<MoveSpring> ().enabled) 
		{
			spring2.GetComponent<MoveSpring> ().enabled = false;
			isOneOn = false;
			ShiftGameNoteMessage ();
		}
			
		//box3
		if (Input.GetButtonDown ("Fire3") && isOneOn == false && !isInPlay) 
		{
			spring3.GetComponent<MoveSpring> ().enabled = true;
			isOneOn = true;
			ShiftGameNoteMessage (spring3);
		}
		else if (Input.GetButtonDown ("Fire3") && spring3.GetComponent<MoveSpring> ().enabled) 
		{
			spring3.GetComponent<MoveSpring> ().enabled = false;
			isOneOn = false;
			ShiftGameNoteMessage ();
		}
			


		if (isOneOn == false && Input.GetButtonDown ("Submit")) 
		{
			ball.GetComponent<Rigidbody2D> ().isKinematic = false;
			button.SetActive (true);
			isInPlay = true;
			gameNote.text = "Let's see how this would play out. Press reset button to reset the ball.";
		}
	}

	void ShiftGameNoteMessage(GameObject spring)
	{
		gameNote.text = "You picked up " + spring.name + "\nUse the arrowKeys to move. Press it's corresponding number to place it.";
	}

	void ShiftGameNoteMessage()
	{
		gameNote.text = "Press enter after you've finished placing springs to play the scene.";
	}

	//For Reset button
	public void Reset()
	{
		ball.transform.position = initialPos;
		ball.GetComponent<Rigidbody2D> ().isKinematic = true;
		isInPlay = false;
		gameNote.text = "Game Reset";
	}
}
