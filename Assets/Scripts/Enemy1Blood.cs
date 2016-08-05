using UnityEngine;
using System.Collections;

public class Enemy1Blood : MonoBehaviour {

	public int maxHealth = 100;
	public int curHealty = 100;

	public float healtyBarLength;
	public float LeastHealtyBarLength;

	private float bloodLocation;
	private float enemyImageLocation;

	public Texture enemy1;
	GUIStyle style = new GUIStyle();

	// Use this for initialization
	void Start () {
		healtyBarLength = Screen.width / 4;
		LeastHealtyBarLength = Screen.width / 10;
		bloodLocation = Screen.width / 2;
		enemyImageLocation = bloodLocation + 40;
	}

	// Update is called once per frame
	void Update () {
		AddJustCurrentHealty (0);
		//this.EnemyAddJustCurrentHealty(-10,curHealty,maxHealth);
		if (curHealty == 0) {
			GameObject go1 = GameObject.Find ("Enemy1");
			go1.SetActive (false);
			//Destroy(go1);
		}
			
	}

	void OnGUI(){
		GUI.Box (new Rect (bloodLocation, 20, 35, 35), enemy1, style);
		GUI.Box (new Rect (enemyImageLocation, 20, healtyBarLength, 20), curHealty + "/" + maxHealth);
	}


	public void AddJustCurrentHealty(int adj){

		curHealty += adj;

		if(curHealty < 0)
			curHealty = 0;

		if (curHealty > maxHealth)
			curHealty = maxHealth; 

		healtyBarLength = (Screen.width / 4) * (curHealty / (float)maxHealth);

		if (healtyBarLength < LeastHealtyBarLength) {
			healtyBarLength = LeastHealtyBarLength;
		}


		//EnemyBlood eb = (EnemyBlood)GetComponent ("EnemyBlood");
		//eb.EnemyAddJustCurrentHealty (adj, curHealty, maxHealth);
	}

	/*
	public void AddJustCurrentHealty(int adj){
		curHealty += adj;

		if(curHealty < 0)
			curHealty = 0;

		if (curHealty > maxHealth)
			curHealty = maxHealth; 

		if (maxHealth < 1)
			maxHealth = 1;

		healtyBarLength = (Screen.width / 4) * (curHealty / (float)maxHealth);

		if (healtyBarLength < LeastHealtyBarLength) {
			healtyBarLength = LeastHealtyBarLength;
		}

	}
    */


}
