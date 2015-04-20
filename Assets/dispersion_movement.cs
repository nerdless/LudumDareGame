using UnityEngine;
using System.Collections;

public class dispersion_movement : MonoBehaviour {
	public float speed;
	void Start ()
	{
		GetComponent<Rigidbody2D>().velocity = transform.up*speed;
	}
}
