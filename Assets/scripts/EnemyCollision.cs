using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D collider)
	{
		if (collider.gameObject.tag == "Player") 
		{
			collider.gameObject.SendMessage("ApplyDamage");
			DestroyByCollision();
		}
	}

	void DestroyByCollision(){
		Destroy (gameObject);
	}


}
