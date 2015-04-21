using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	Text text;

	void Awake ()
	{
		text = GetComponent<Text> ();
		ScoreCounter.score = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		text.text = "Score: " + ScoreCounter.score;
	}
}
