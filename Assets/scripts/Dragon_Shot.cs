using UnityEngine;
using System.Collections;

public class Dragon_Shot : MonoBehaviour {
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;

	private float nextFire;
	private float horizontalSpeed;
	private Vector3 initialPosition;


	// Use this for initialization
	void Start () {
		initialPosition = transform.position;
		horizontalSpeed = -0.01f;
		nextFire = 0;
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
		Shoot ();
	}

	void Move()
	{
		Vector3 newPosition;
		newPosition = new Vector3 (initialPosition.x + horizontalSpeed, initialPosition.y, initialPosition.z);
		transform.position = newPosition;
		initialPosition = transform.position;
	}

	void Shoot()
	{
		if (Time.time > nextFire) 
		{
			nextFire = Time.time + fireRate;
			Instantiate(shot, shotSpawn.position, shot.transform.rotation);
		}
	}

	void Slow()
	{
		this.horizontalSpeed /= 2;
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
}
