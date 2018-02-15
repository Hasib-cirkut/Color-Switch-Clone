using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	public float upwardForce = 10f;
	private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown("space") || Input.GetMouseButtonDown(0))
			{
			rb.velocity = new Vector2(0, upwardForce);
			}

	}


}
