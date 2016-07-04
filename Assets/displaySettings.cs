using UnityEngine;
using System.Collections;

public class displaySettings : MonoBehaviour {

	private int selected;
	// Use this for initialization
	void Start () {
		selected = PlayerPrefs.GetInt ("selectedCharacter");
		if (selected == 2)
			gameObject.SetActive (true);
		else
			gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
