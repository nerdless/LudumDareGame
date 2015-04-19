using UnityEngine;
using System.Collections;

public class Move_enemy_laser : MonoBehaviour {

	private GameObject User;
	public float speed;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity = new Vector3(speed, 0.0f, 0.0f);
		User = GameObject.FindGameObjectWithTag ("Player");
	}

	void Update()
	{
		float userY = User.transform.position.y;
		float shipY = transform.position.y;
		float verticalSpeed = (userY - shipY) / 40;
		Vector3 newPosition = new Vector3 (transform.position.x, transform.position.y + verticalSpeed, transform.position.z);
		transform.position = newPosition;

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "PlayerBullet") 
		{
			Destroy(other.gameObject);
			Destroy (gameObject);
		}
		if (other.gameObject.tag == "Player") 
		{
			//Debug.Log ("hit user");
			User.SendMessage("ApplyDamage");
			Destroy (gameObject);
		}
	}


}
