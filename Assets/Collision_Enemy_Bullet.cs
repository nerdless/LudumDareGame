using UnityEngine;
using System.Collections;

public class Collision_Enemy_Bullet : MonoBehaviour{
	//private GameObject player;

	void Start()
	{
		//player = GameObject.FindGameObjectWithTag ("Player");
	}

	void OnCollisionEnter2D(Collision2D collider)
	{
		Debug.Log ("hit something");
		if (collider.gameObject.tag == "Player") 
		{
			Debug.Log ("A bullet hit player");
			Destroy(collider.gameObject);
			Destroy(gameObject);
		}
	}

}
