using UnityEngine;
using System.Collections;

public class EnemyLifes : MonoBehaviour {

	public int lifes;
	private GameObject player;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	void FixedUpdate () {
		if (lifes < 1)
			Die ();
		
		
	}
	
	void Die(){
		Debug.Log ("You beat it");
		int points;	
		Debug.Log ("enemy tag: " + this.gameObject.tag);
		if (this.gameObject.tag == "Crane")
			points = 1;
		else if (this.gameObject.tag == "Pegasus")
			points = 3;
		else if (this.gameObject.tag == "Dragon")
			points = 5;
		else 
			points = 0;
		player.SendMessage ("addToScore", points);
		Destroy (gameObject);

	}
	
	void ApplyDamage()
	{
		lifes -= 1;
		//Debug.Log ("you have been damaged");
	}
}
