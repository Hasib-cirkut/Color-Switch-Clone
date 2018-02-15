using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	public float rotationSpeed = 100f;

	void LateUpdate()
	{
		transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
	}
}
