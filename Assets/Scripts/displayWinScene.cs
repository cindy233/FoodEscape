using UnityEngine;
using System.Collections;

public class displayWinScene : MonoBehaviour {

	private int selected;
	private GameObject Player;
	// Use this for initialization
	void Start () {


		selected = PlayerPrefs.GetInt ("selectedCharacter");
		Player = GameObject.Find ("Player");

		switch (selected) {
		case 1:
			Player.transform.FindChild ("taichi1").gameObject.SetActive(true);
			Player.transform.FindChild ("unitychan").gameObject.SetActive (false);
			Player.transform.FindChild ("querychan").gameObject.SetActive (false);
			break;
		case 2:
			Player.transform.FindChild ("taichi1").gameObject.SetActive(false);
			Player.transform.FindChild ("unitychan").gameObject.SetActive (true);
			Player.transform.FindChild ("querychan").gameObject.SetActive (false);
			break;
		case 3:
			Player.transform.FindChild ("taichi1").gameObject.SetActive(false);
			Player.transform.FindChild ("unitychan").gameObject.SetActive (false);
			Player.transform.FindChild ("querychan").gameObject.SetActive (true);
			break;
		default:
			break;

		}

	}

	// Update is called once per frame
	void Update () {

	}
		
}
