using UnityEngine;
using System.Collections;

public class EnemyLifes : MonoBehaviour {

	public int lifes;
	
	void FixedUpdate () {
		if (lifes < 1)
			Die ();
		
		
	}
	
	void Die(){
		Debug.Log ("You beat it");
		//Explote();	
		Destroy (gameObject);
	}
	
	void ApplyDamage()
	{
		lifes -= 1;
		//Debug.Log ("you have been damaged");
	}
}
