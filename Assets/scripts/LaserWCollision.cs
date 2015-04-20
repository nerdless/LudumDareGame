using UnityEngine;
using System.Collections;

public class LaserWCollision : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D collider)
	{
		//Debug.Log ("hit something");
		
		if (collider.gameObject.tag == "Crane"||
		    collider.gameObject.tag == "Pegasus"||
		    collider.gameObject.tag == "Dragon") 
		{
			//Debug.Log ("hit with Pegasus");
			collider.gameObject.SendMessage("Slow");
			Destroy(gameObject);
		}
		
	}
}
