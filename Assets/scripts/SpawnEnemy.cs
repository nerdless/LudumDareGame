using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {

	public Camera mainCamera;	
	public Vector3 upperCorner;
	public Transform enemy;
	public float SpawnRate;
	private float nextEnemy;
	private Vector3 SpawnPosition;

	void Start () 
	{
		mainCamera = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<Camera> ();
		upperCorner = new Vector3 (Screen.width, Screen.height, 0.0f);
		upperCorner = mainCamera.ScreenToWorldPoint(upperCorner);
	}
	
	void Update () 
	{
		if(Time.time > nextEnemy)
		{
			nextEnemy += SpawnRate;
			SpawnPosition = new Vector3(upperCorner.x, Random.Range(-upperCorner.y, upperCorner.y),0);
			Quaternion spawnRotation = enemy.rotation;
			Instantiate(enemy, SpawnPosition, spawnRotation);
		}
	}
}
