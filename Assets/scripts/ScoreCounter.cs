using UnityEngine;
using System.Collections;

public class ScoreCounter : MonoBehaviour {

	public int score;
	void Start () {
		score = 0;
	}

	public void addToScore(int points)
	{
		score += points;
		Debug.Log("you got "+points+" points");
	}

}
