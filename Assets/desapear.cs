using UnityEngine;
using System.Collections;

public class desapear : MonoBehaviour {
	private float startTime;
	public float duration;
	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > startTime + duration)
			Destroy (gameObject);
	}
}
