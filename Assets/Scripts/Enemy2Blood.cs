using UnityEngine;
using System.Collections;

public class Enemy2Blood : MonoBehaviour {

	public int maxHealth = 100;
	public int curHealty = 100;

	public float healtyBarLength;
	public float LeastHealtyBarLength;

	private float bloodLocation;
	private float enemyImageLocation;

	public Texture enemy2;
	GUIStyle style = new GUIStyle();

	//public float LeastHealtyBarLength;
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
		if (curHealty == 0) {
			GameObject go2 = GameObject.Find ("Enemy2");
			go2.SetActive (false);
			//Destroy(go2);
		}
	}

	void OnGUI(){
		GUI.Box (new Rect (bloodLocation, 60, 35, 35), enemy2, style);
		GUI.Box (new Rect (enemyImageLocation, 60, healtyBarLength, 20), curHealty + "/" + maxHealth);
	}


	public void AddJustCurrentHealty(int adj){
		//a = adj;
		curHealty += adj;

		if(curHealty < 0)
			curHealty = 0;

		if (curHealty > maxHealth)
			curHealty = maxHealth; 

		healtyBarLength = (Screen.width / 4) * (curHealty / (float)maxHealth);

		if (healtyBarLength < LeastHealtyBarLength) {
			healtyBarLength = LeastHealtyBarLength;
		}
	}
}
