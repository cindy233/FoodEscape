using UnityEngine;
using System.Collections;

public class displaySettings : MonoBehaviour {

	private int selected;
	private GameObject player;
	private GameObject Capsule;
	private GameObject[] Enemies;
	private int enemyInd=3;

	// Use this for initialization
	void Start () {

		Enemies = new GameObject[enemyInd];
		selected = PlayerPrefs.GetInt ("selectedCharacter");
		Capsule = GameObject.Find ("Potato");

		for (int i = 0; i < enemyInd; i++) {
		
			string enemyName = "Enemy" + (i+1).ToString ();
			GameObject ene = GameObject.Find (enemyName);
			Enemies [i] = ene;
		
		}

		//Butcher = GameObject.Find ("TheButcher");
		FollowingPlayer fplayer = Capsule.GetComponent<FollowingPlayer> ();
		//ButcherAttack butcherAttack = Butcher.GetComponent<ButcherAttack> ();
		CameraControl cControl = GameObject.Find("Main Camera").GetComponent<CameraControl>();

		switch (selected) {
		case 1:
			player = transform.FindChild ("taichi1").gameObject;
			player.SetActive (true);
			transform.FindChild ("unitychan").gameObject.SetActive (false);
			transform.FindChild ("querychan").gameObject.SetActive (false);
			//butcherAttack.player = player;
			UpdateEnemyPlayer ();
			cControl.target = player.transform;
			break;
		case 2:
			player = transform.FindChild ("unitychan").gameObject;
			player.SetActive (true);
			transform.FindChild ("taichi1").gameObject.SetActive (false);
			transform.FindChild ("unitychan").gameObject.SetActive (true);
			transform.FindChild ("querychan").gameObject.SetActive (false);
			//butcherAttack.player = player;
			UpdateEnemyPlayer ();
			cControl.target = player.transform;
			break;
		case 3:
			player = transform.FindChild ("querychan").gameObject;
			player.SetActive (true);
			transform.FindChild ("taichi1").gameObject.SetActive (false);
			transform.FindChild ("unitychan").gameObject.SetActive (false);
			transform.FindChild ("querychan").gameObject.SetActive (true);
			//butcherAttack.player = player;
			UpdateEnemyPlayer ();
			cControl.target = player.transform;
			break;
		default:
			break;

		}
		fplayer.player = player;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void UpdateEnemyPlayer(){
	
		for (int i = 0; i < enemyInd; i++) {

			ButcherAttack butcherAttack = Enemies[i].GetComponent<ButcherAttack> ();

			butcherAttack.player = player;

		}
	}
}
