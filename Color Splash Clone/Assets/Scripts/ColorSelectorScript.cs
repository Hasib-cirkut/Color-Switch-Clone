using UnityEngine;
using UnityEngine.SceneManagement;
using System.Security.Cryptography;


public class ColorSelectorScript : MonoBehaviour {

	public Color Red;
	public Color Magenta;
	public Color Blue;
	public Color Yellow;

	private string CurrentColor;

	private SpriteRenderer sr;
	//public GameObject colorChanger;

	private int randVal, prevVal = 0;

	void Start()
	{
		sr = GetComponent<SpriteRenderer>();

		randomColorGenarator();
	}


		void OnTriggerEnter2D(Collider2D col)
		{
			


			if(col.tag == "ColorChangerAnomaly1") // If the collider is an anomaly color changer
			{
			if(CurrentColor == "Blue")
			{
				sr.color = Magenta;
				CurrentColor = "Magenta";
				Destroy(col.gameObject);
				return;
			}
			if(CurrentColor == "Magenta")
			{
				sr.color = Blue;
				CurrentColor = "Blue";
				Destroy(col.gameObject);
				return;
			}

			if(CurrentColor != "Magenta" && CurrentColor != "Blue")
			{
				CurrentColor ="Blue";
				sr.color = Blue;
				Destroy(col.gameObject);
				return;
			}

		
			}
//			randomColorGenaratorAnomaly1();
//			Destroy(col.gameObject);
//
//			return;



			if(col.tag == "ColorChanger") //If the collider is an normal color changer
			{
			randomColorGenarator();
			Destroy(col.gameObject);

			return;
			}
			
			 
		if(CurrentColor != col.tag){ //If the ball hits wrong colored walls
			
			Debug.Log("GameOver");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			}
			else
			{
			Debug.Log(col.tag);
			}

		}





		public void randomColorGenarator()
		{
		

		randVal = Random.Range(1, 4);


		if(randVal != prevVal){

			prevVal = randVal;

		switch(randVal)
		{
		case 1:
			sr.color = Red;
				CurrentColor = "Red";
			break;
		case 2:
			sr.color = Yellow;
				CurrentColor = "Yellow";
				break;
		case 3:
			sr.color = Blue;
				CurrentColor = "Blue";
			break;
		case 4:
			sr.color = Magenta;
				CurrentColor = "Magenta";
			break;

		}

		}
		else{
			randomColorGenarator();
		}

		//prevVal = randVal;
	}

//	public void randomColorGenaratorAnomaly1() //Chooses between Red and Yellow
//	{
//		randVal = Random.Range(1, 2);
//
//
//		if(randVal != prevVal){
//
//			prevVal = randVal;
//
//			switch(randVal)
//			{
//			case 1:
//				sr.color = Red;
//				CurrentColor = "Red";
//				break;
//			case 2:
//				sr.color = Yellow;
//				CurrentColor = "Yellow";
//				break;
//			}
//		}
//		else
//		{
//			randomColorGenaratorAnomaly1();
//		}
//}

}
