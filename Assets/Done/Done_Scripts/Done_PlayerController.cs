using UnityEngine;
using System.Collections;

[System.Serializable]
public class Done_Boundary 
{
	public float xMin, xMax, zMin, zMax;
}


public class Done_PlayerController : MonoBehaviour
{
	public float speed;
	//public float tilt;
	public Done_Boundary boundary;

	public GameObject shotQ;
	public Transform shotQSpawn;
	public float fireRateQ;
	private float nextFireQ;

	public GameObject shotW;
	public Transform shotWSpawn;
	public float fireRateW;
	private float nextFireW;

	public GameObject shotE;
	public Transform shotESpawn;
	public float fireRateE;
	private float nextFireE;

	public GameObject shotR;
	public Transform shotRSpawn;
	public float fireRateR;
	private float nextFireR;



	public Camera mainCamera;
	private Vector3 upperCorner;
	public float horizontalPosition;

	void Start ()
	{
		upperCorner = new Vector3 (Screen.width, Screen.height, 0.0f);
		upperCorner = mainCamera.ScreenToWorldPoint(upperCorner);
		//Debug.Log ("upper corner: " + upperCorner);
		nextFireQ = 0; //cause Zhou ask for it
		nextFireW = 0;
		nextFireE = 0;
		nextFireR = 0;
	}
	
	void Update ()
	{
		if (Input.GetKey(KeyCode.Q) && Time.time > nextFireQ) 
		{
			nextFireQ = Time.time + fireRateQ;
			Instantiate(shotQ, shotQSpawn.position, shotQ.transform.rotation);
			GetComponent<AudioSource>().Play ();
		}
		if (Input.GetKey(KeyCode.W) && Time.time > nextFireW) 
		{
			nextFireW = Time.time + fireRateW;
			Instantiate(shotW, shotWSpawn.position, shotWSpawn.rotation);
			GetComponent<AudioSource>().Play ();
		}
		if (Input.GetKey(KeyCode.E) && Time.time > nextFireE) 
		{
			nextFireE = Time.time + fireRateE;
			Instantiate(shotE, shotESpawn.position, shotESpawn.rotation);
			GetComponent<AudioSource>().Play ();
		}
		if (Input.GetKey(KeyCode.R) && Time.time > nextFireR) 
		{
			nextFireR = Time.time + fireRateR;
			Instantiate(shotR, shotRSpawn.position, shotRSpawn.rotation);
			GetComponent<AudioSource>().Play ();
		}
	}

	void FixedUpdate ()
	{
		//float moveVertical = Input.GetAxis ("Vertical");
		bool pressup =Input.GetKey (KeyCode.UpArrow);
		bool pressdown = Input.GetKey (KeyCode.DownArrow);
		bool pressrigth = Input.GetKey (KeyCode.RightArrow);
		bool pressleft = Input.GetKey (KeyCode.LeftArrow);

		float moveVertical = 0;
		float moveHorizontal = 0;
		if (pressup)
			moveVertical += 1;
		if (pressdown)
			moveVertical -= 1;
		if (pressrigth)
			moveHorizontal += 1;
		if (pressleft)
			moveHorizontal -= 1;

		Vector3 movement = new Vector3 (moveHorizontal, moveVertical, 0.0f);
		GetComponent<Rigidbody2D>().velocity = movement * speed;
		GetComponent<Rigidbody2D>().position = new Vector3
		(
				//horizontalPosition, //for constraits in horizontal position
				Mathf.Clamp (GetComponent<Rigidbody2D>().position.x, -upperCorner.x, upperCorner.x),
				Mathf.Clamp (GetComponent<Rigidbody2D>().position.y, -upperCorner.y, upperCorner.y),
				0.0f
			
		);
		/*
		GetComponent<Rigidbody>().rotation = Quaternion.Euler (0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * -tilt);
		*/
	}
}
