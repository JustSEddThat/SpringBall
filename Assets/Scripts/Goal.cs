using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Goal : MonoBehaviour 
{
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (SceneManager.GetActiveScene ().buildIndex == 0) 
		{
			
			if (other.CompareTag ("Player"))
				SceneManager.LoadScene (0);
		} 
		else if (other.CompareTag ("Player") && SceneManager.GetActiveScene ().buildIndex == 3)
			SceneManager.LoadScene (0);
		else 
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);

		}
	}

}
