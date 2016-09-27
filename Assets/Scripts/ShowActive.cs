using UnityEngine;
using System.Collections;

public class ShowActive : MonoBehaviour 
{

	public GameObject mother;
	void Start () 
	{
		gameObject.GetComponent<MeshRenderer> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (mother.GetComponent<MoveSpring> ().enabled)
			gameObject.GetComponent<MeshRenderer> ().enabled = true;
		else
			gameObject.GetComponent<MeshRenderer> ().enabled = false;
			
	}
}
