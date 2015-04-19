using UnityEngine;
using System.Collections;

public class DestroyEnemies : MonoBehaviour {
	

	void OnCollisionEnter2D(Collision2D collider)
	{
		//Debug.Log ("hit something");
		if (collider.gameObject.tag == "EnemyBullet") 
		{
			//Debug.Log ("hit with enemy Bullet");
			Destroy(collider.gameObject);
			Destroy(gameObject);
		}
		if (collider.gameObject.tag == "Crane") 
		{
			//Debug.Log ("hit with Crane");
			Destroy(collider.gameObject);
			Destroy(gameObject);
		}
		if (collider.gameObject.tag == "Pegasus") 
		{
			//Debug.Log ("hit with Pegasus");
			Destroy(collider.gameObject);
			Destroy(gameObject);
		}

	}
}
