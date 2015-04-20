using UnityEngine;
using System.Collections;

public class Move3Cones : MonoBehaviour {

	public float speed;
	public GameObject cone1,cone2, cone3;
	
	void Start ()
	{
		GetComponent<Rigidbody2D>().velocity = new Vector3(speed, 0.0f,0.0f);
	}
	
	void FixedUpdate()
	{
		if(Input.GetKeyDown(KeyCode.E))
		{
			Instantiate(cone1,gameObject.transform.position, cone1.gameObject.transform.rotation);
			Instantiate(cone2,gameObject.transform.position, cone2.gameObject.transform.rotation);
			Instantiate(cone3,gameObject.transform.position, cone3.gameObject.transform.rotation);
			Destroy(gameObject);
		}
	}
}
