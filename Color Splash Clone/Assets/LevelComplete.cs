
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

	//bool levelComplete = false;



	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.tag == "Player")
		{
			SceneManager.LoadScene("BackToMainMenu");			
		}
	}


}
