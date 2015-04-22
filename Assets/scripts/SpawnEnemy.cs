using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {

	public Camera mainCamera;	
	public Vector3 upperCorner;
	public Transform enemy;
	public float SpawnRate;
	private float nextEnemy;
	private Vector3 SpawnPosition;

	public GameObject BiggestElementBelow;
	public float lowPadding;

	void Start () 
	{
		mainCamera = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<Camera> ();
		upperCorner = new Vector3 (Screen.width, Screen.height, 0.0f);
		upperCorner = mainCamera.ScreenToWorldPoint(upperCorner);

		lowPadding = 2*BiggestElementBelow.GetComponent<SpriteRenderer> ().sprite.bounds.extents.y*BiggestElementBelow.transform.localScale.x;
		//lowPadding += gameObject.GetComponent<SpriteRenderer> ().sprite.bounds.extents.y*gameObject.transform.localScale.x;

	}
	
	void Update () 
	{
		if(Time.timeSinceLevelLoad > nextEnemy)
		{
			nextEnemy += SpawnRate;
			SpawnPosition = new Vector3(upperCorner.x, Random.Range(-upperCorner.y+lowPadding, upperCorner.y),0);
			Quaternion spawnRotation = enemy.rotation;
			Instantiate(enemy, SpawnPosition, spawnRotation);
		}
	}
}
