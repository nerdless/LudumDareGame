using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour {

	public Vector2 horizontalBounds;
	public Camera mainCamera;	
	public Vector3 upperCorner;

	void Start ()
	{
		mainCamera = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<Camera> ();
		upperCorner = new Vector3 (Screen.width, Screen.height, 0.0f);
		upperCorner = mainCamera.ScreenToWorldPoint(upperCorner);
		//Debug.Log ("upper corner: " + upperCorner);
	}


	void FixedUpdate () {

		if (GetComponent<Rigidbody2D> ().position.x > upperCorner.x ||
			GetComponent<Rigidbody2D> ().position.x < -upperCorner.x ||
		    GetComponent<Rigidbody2D> ().position.y > upperCorner.y ||
			GetComponent<Rigidbody2D> ().position.y < -upperCorner.x)
		{
			//Debug.Log("The projectile was in: "+GetComponent<Rigidbody2D> ().position);
			Destroy (gameObject);
		}


	
	}
}
