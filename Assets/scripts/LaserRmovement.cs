using UnityEngine;
using System.Collections;

public class LaserRmovement : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) 
		{
			//Destroy (gameObject);
			Explosion();
		}
	}

	void Explosion()
	{
		Vector2 center = new Vector2(transform.position.x, transform.position.y);
		float radius = 3;
		Collider2D [] hitColliders = Physics2D.OverlapCircleAll (center, radius);

		for (int i = 0; i< hitColliders.Length; i++) 
		{
			if(hitColliders[i].gameObject.tag == "Crane" || hitColliders[i].gameObject.tag == "Pegasus" || hitColliders[i].gameObject.tag == "Dragon")
			{
				hitColliders[i].gameObject.SendMessage("ApplyDamage", 4);
			//Destroy (hitColliders[i].gameObject);
			}
		}
		Destroy (gameObject);
	}
}
