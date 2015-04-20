using UnityEngine;
using System.Collections;

public class EnemyCollider : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		switch(other.gameObject.tag)
		{
			default:
				break;
			case "BulletQ":
				Destroy (other.gameObject);
				gameObject.SendMessage("ApplyDamage",1);
				break;
				
			case "BulletW":
				this.gameObject.SendMessage("Slow");
				Destroy(other.gameObject);
				break;
				
			case "BulletE":
				Destroy (other.gameObject);
				gameObject.SendMessage("ApplyDamage",2);
				break;
				
			case "Player":
				other.SendMessage("ApplyDamage");
				Destroy(gameObject);
				break;
			
		}
		
	}
}
