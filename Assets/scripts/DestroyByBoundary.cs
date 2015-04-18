using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour {

	public Transform Player;
	public Vector2 horizontalBounds;
	public Vector2 verticalBounds;

	void Start ()
	{
		horizontalBounds = new Vector2 (Player.GetComponent<Done_PlayerController> ().boundary.xMin,
		                              Player.GetComponent<Done_PlayerController> ().boundary.xMax);

		verticalBounds = new Vector2 (Player.GetComponent<Done_PlayerController> ().boundary.zMin,
		                               Player.GetComponent<Done_PlayerController> ().boundary.zMax);
	}

	void Update () {
	
	}
}
