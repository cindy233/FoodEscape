using UnityEngine;
using System.Collections;

public class displaySettings : MonoBehaviour {

	private int selected;
	private GameObject player;
	private GameObject Capsule;

	// Use this for initialization
	void Start () {
		
		selected = PlayerPrefs.GetInt ("selectedCharacter");
		Capsule = GameObject.Find ("Capsule");
		FollowingPlayer fplayer = Capsule.GetComponent<FollowingPlayer> ();

		switch (selected) {
		case 1:
			player = transform.FindChild ("taichi1").gameObject;
			player.SetActive (true);
			transform.FindChild ("unitychan").gameObject.SetActive (false);
			transform.FindChild ("querychan").gameObject.SetActive (false);
			break;
		case 2:
			player = transform.FindChild ("unitychan").gameObject;
			player.SetActive (true);
			transform.FindChild ("taichi1").gameObject.SetActive (false);
			transform.FindChild ("unitychan").gameObject.SetActive (true);
			transform.FindChild ("querychan").gameObject.SetActive (false);
			break;
		case 3:
			player = transform.FindChild ("querychan").gameObject;
			player.SetActive (true);
			transform.FindChild ("taichi1").gameObject.SetActive (false);
			transform.FindChild ("unitychan").gameObject.SetActive (false);
			transform.FindChild ("querychan").gameObject.SetActive (true);
			break;
		default:
			break;

		}
		fplayer.player = player;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
