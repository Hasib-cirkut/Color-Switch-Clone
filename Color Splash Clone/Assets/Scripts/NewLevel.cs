﻿
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLevel : MonoBehaviour {


	public void LoadNextLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}


}
