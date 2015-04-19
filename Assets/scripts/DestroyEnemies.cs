using UnityEngine;
using System.Collections;

public class DestroyEnemies : MonoBehaviour {
	

	void OnCollisionEnter2D(Collision2D collider)
	{
		//Debug.Log ("hit something");
		if (collider.gameObject.tag == "Crane") 
		{
			//Debug.Log ("hit with Crane");
			Destroy(collider.gameObject);
			Destroy(gameObject);
		}
	}
}
