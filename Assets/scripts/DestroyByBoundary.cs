using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour {

	public Transform Player;
	public Vector2 horizontalBounds;
	public Vector2 verticalBounds;


	void Update () {

		if (GetComponent<Rigidbody2D> ().position.x > horizontalBounds.y ||
			GetComponent<Rigidbody2D> ().position.x < horizontalBounds.x ||
		    GetComponent<Rigidbody2D> ().position.y > verticalBounds.y ||
			GetComponent<Rigidbody2D> ().position.y < verticalBounds.x)
		{
			Debug.Log("estaba en: "+GetComponent<Rigidbody2D> ().position);
			Destroy (gameObject);

		}


	
	}
}
