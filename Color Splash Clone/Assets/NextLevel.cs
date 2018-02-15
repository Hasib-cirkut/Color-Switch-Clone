using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour {

	public void PushLevel()
	{
		SceneManager.LoadScene("Game");
	}

	public void MainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}
}

