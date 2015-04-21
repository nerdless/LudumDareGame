using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ReLoadGame : MonoBehaviour {

	void FixedUpdate()
	{
		if (Input.GetKey (KeyCode.Space))
			Application.LoadLevel (1);
	}
}
