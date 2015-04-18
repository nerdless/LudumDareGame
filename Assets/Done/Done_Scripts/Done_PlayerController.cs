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

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	private float nextFire;

	private Vector3 upperCorner;

	void Start ()
	{
		upperCorner = new Vector3 (Screen.width, Screen.height, 0.0f);
		Debug.Log ("upper corner: " + upperCorner);
	}
	
	void Update ()
	{
		if (Input.GetKey(KeyCode.Space) && Time.time > nextFire) 
		{
			nextFire = Time.time + fireRate;
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
			GetComponent<AudioSource>().Play ();
		}
	}

	void FixedUpdate ()
	{
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (0.0f, moveVertical, 0.0f);
		GetComponent<Rigidbody2D>().velocity = movement * speed;
		
		GetComponent<Rigidbody2D>().position = new Vector3
		(
				-8.0f, 
				Mathf.Clamp (GetComponent<Rigidbody2D>().position.y, -5.0f, 5.0f),
				0.0f
			
		);
		/*
		GetComponent<Rigidbody>().rotation = Quaternion.Euler (0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * -tilt);
		*/
	}
}
