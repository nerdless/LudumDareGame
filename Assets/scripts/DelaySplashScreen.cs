using UnityEngine;
using System.Collections;

public class DelaySplashScreen : MonoBehaviour {

	private float starttime;
	private float delay = 3;
	// Use this for initialization
	void Start () {
		starttime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > starttime + delay)
			Application.LoadLevel (1);
	}
}
