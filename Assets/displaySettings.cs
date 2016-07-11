using UnityEngine;
using System.Collections;

public class displaySettings : MonoBehaviour {

	private int selected;
	private GameObject player;
	private GameObject Capsule;
	private GameObject Butcher;

	// Use this for initialization
	void Start () {
		
		selected = PlayerPrefs.GetInt ("selectedCharacter");
		Capsule = GameObject.Find ("Potato");
		Butcher = GameObject.Find ("TheButcher");
		FollowingPlayer fplayer = Capsule.GetComponent<FollowingPlayer> ();
		ButcherAttack butcherAttack = Butcher.GetComponent<ButcherAttack> ();

		switch (selected) {
		case 1:
			player = transform.FindChild ("taichi1").gameObject;
			player.SetActive (true);
			transform.FindChild ("unitychan").gameObject.SetActive (false);
			transform.FindChild ("querychan").gameObject.SetActive (false);
			butcherAttack.player = player;
			break;
		case 2:
			player = transform.FindChild ("unitychan").gameObject;
			player.SetActive (true);
			transform.FindChild ("taichi1").gameObject.SetActive (false);
			transform.FindChild ("unitychan").gameObject.SetActive (true);
			transform.FindChild ("querychan").gameObject.SetActive (false);
			butcherAttack.player = player;
			break;
		case 3:
			player = transform.FindChild ("querychan").gameObject;
			player.SetActive (true);
			transform.FindChild ("taichi1").gameObject.SetActive (false);
			transform.FindChild ("unitychan").gameObject.SetActive (false);
			transform.FindChild ("querychan").gameObject.SetActive (true);
			butcherAttack.player = player;
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
