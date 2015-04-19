using UnityEngine;
using System.Collections;

public class Life_Counter : MonoBehaviour {

	public int lifes;

	void Start () {
	
	}
	

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
