using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ButtonScript : MonoBehaviour {

	// Use this for initialization

	public void ToMainLevel()
	{
		SceneManager.LoadScene (1);
	}
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
