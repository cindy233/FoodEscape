using UnityEngine;
using System.Collections;

public class displaySettings : MonoBehaviour {

	private int selected;
//	private GameObject taichi1;

	// Use this for initialization
	void Start () {
		
		selected = PlayerPrefs.GetInt ("selectedCharacter");

		switch (selected) {
		case 1:
			transform.FindChild ("taichi1").gameObject.SetActive (true);
			transform.FindChild ("unitychan").gameObject.SetActive (false);
			transform.FindChild ("querychan").gameObject.SetActive (false);
			break;
		case 2:
			transform.FindChild ("taichi1").gameObject.SetActive (false);
			transform.FindChild ("unitychan").gameObject.SetActive (true);
			transform.FindChild ("querychan").gameObject.SetActive (false);
			break;
		case 3:
			transform.FindChild ("taichi1").gameObject.SetActive (false);
			transform.FindChild ("unitychan").gameObject.SetActive (false);
			transform.FindChild ("querychan").gameObject.SetActive (true);
			break;
		default:
			break;

		}


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
