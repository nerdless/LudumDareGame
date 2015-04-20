using UnityEngine;
using System.Collections;

public class enemy_movement : MonoBehaviour {
	private GameObject User;

	private Vector3 initialPosition;
	public float verticalSpeedControl, horizontalSpeed;
	private float verticalSpeed;

	// Use this for initialization
	void Start () 
	{
		User = GameObject.FindGameObjectWithTag("Player");
		initialPosition = transform.position;
		//horizontalSpeed = -0.01f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		float userY = User.transform.position.y;
		float shipY = transform.position.y;
		verticalSpeed = (userY - shipY) * verticalSpeedControl/ 100;
		Accelerate ();
		MoveShip ();
	}

	void Accelerate()
	{
		if (initialPosition.x < -2) {
			horizontalSpeed -= 0.002f;
			verticalSpeed = 0;
		}
	}

	void MoveShip()
	{
		Vector3 newPosition;
		newPosition = new Vector3 (initialPosition.x + horizontalSpeed, initialPosition.y + verticalSpeed, initialPosition.z);
		transform.position = newPosition;
		initialPosition = transform.position;
	}

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
			Destroy(other.gameObject);
			Slow ();
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

	void Slow()
	{
		this.horizontalSpeed /= 2.0f;
	}
}
