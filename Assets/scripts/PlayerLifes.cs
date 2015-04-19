using UnityEngine;
using System.Collections;

public class PlayerLifes : MonoBehaviour {

	public int lifes;

	void FixedUpdate () {
		if (lifes < 1)
			Die ();
	}

	void Die(){
		Debug.Log ("You are so fuking dead");
		//Explote();
	}

	void ApplyDamage()
	{
		lifes -= 1;
		//Debug.Log ("you have been damaged");
	}


}
