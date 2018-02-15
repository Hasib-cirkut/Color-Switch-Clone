using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBounceScript : MonoBehaviour {

	public GameObject player;


	void LateUpdate()
	{
		if(player.transform.position.y >= transform.position.y)
		{
			transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
		}

	}
}
