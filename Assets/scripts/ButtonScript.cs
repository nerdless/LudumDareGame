using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using SimpleJSON;

public class ButtonScript : MonoBehaviour {

	private const string END_POINT = "http://scores.herokuapp.com/score";

	// Use this for initialization
	void Start () {
		Button button = (Button)GameObject.Find ("saveScore").GetComponent<Button>();
		button.onClick.AddListener (SaveScore);

		renderGameObject ("ScoreForm", true);
		renderGameObject ("ScoreShow", false);

	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void renderGameObject(string name, bool enabled) {
		GameObject o = GameObject.Find (name);
		o.transform.localEulerAngles = new Vector3 (0, enabled ? 0 : 90, 0);
	}


	void SaveScore () {
		int score = 11;
		InputField input = (InputField) GameObject.Find("username").GetComponent<InputField>();
		Debug.Log (input.text);

		renderGameObject ("ScoreForm", false);
	
		string url = END_POINT + "/" + input.text + "/" + score;
		WWW www = new WWW (url);

		StartCoroutine (WaitForResponse(www));
	}

	IEnumerator WaitForResponse(WWW www) {
		yield return www;

		print (www.text);

		renderGameObject ("ScoreShow", true);
		
		JSONArray scores = (JSONArray) JSON.Parse( www.text );
		
		for (int i = 0; i < 6; i++) {

			Text label = GameObject.Find ("user"+i).GetComponent<Text>();
			Text value = GameObject.Find ("score"+i).GetComponent<Text>();
			label.text = "";
			value.text = "";

			if (i < scores.Count) {
				JSONNode bestScore = scores[i];
				label.text = bestScore["username"];
				value.text = bestScore["score"];
			}

		}
	}
}
