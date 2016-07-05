using UnityEngine;
using System.Collections;

public class displaySettings : MonoBehaviour {

	private int selected;
//	private GameObject taichi1;

	// Use this for initialization
	void Start () {
		
		selected = PlayerPrefs.GetInt ("selectedCharacter");
		//taichi1 = GameObject.Find("taichi1");
		switch (selected) {
		case 1:
			//taichi1.gameObject.SetActive (true);
			transform.FindChild ("taichi1").gameObject.SetActive (true);
			transform.FindChild ("unitychan").gameObject.SetActive (false);
			break;
		case 2:
			//taichi1.gameObject.SetActive (true);
			transform.FindChild ("taichi1").gameObject.SetActive (false);
			transform.FindChild ("unitychan").gameObject.SetActive (true);
			break;
		default:
			break;

		}


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
