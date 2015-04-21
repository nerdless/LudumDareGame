using UnityEngine;
using System.Collections;

public class PlayerLifes : MonoBehaviour {

	public GameObject cara0;
	public GameObject cara1;
	public GameObject cara2;
	public GameObject cara3;

	public GameObject ship0;
	public GameObject ship1;
	public GameObject ship2;
	public GameObject ship3;
	public int lifes;

	public GameObject explotion;

	void FixedUpdate () {
		if (lifes < 1)
			Die ();
	}

	void Die(){
		Debug.Log ("You are so fucking dead");
		Instantiate (explotion, transform.position, transform.rotation);
		GetComponent<AudioSource> ().Play ();
		Wait ();
		Application.LoadLevel (1);
		//Explote();
	}

	IEnumerator Wait() 
	{
		yield return new WaitForSeconds(5);
	}

	void ApplyDamage()
	{
		lifes -= 1;
		//Debug.Log ("you have been damaged");
		switch (lifes) {
			default:
				break;
			case 2:
				Destroy (cara0.gameObject);
				Destroy (ship0.gameObject);
				break;
			case 1:
			Destroy (cara1.gameObject);
			Destroy (ship1.gameObject);
				break;
			case 0:
			Destroy (cara2.gameObject);
			Destroy (ship2.gameObject);
				break;
		}
	}


}
