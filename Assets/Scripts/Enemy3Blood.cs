using UnityEngine;
using System.Collections;

public class Enemy3Blood : MonoBehaviour {

	public int maxHealth = 100;
	public int curHealty = 100;

	public float healtyBarLength;
	public Texture enemy3;
	GUIStyle style = new GUIStyle();

	// Use this for initialization
	void Start () {
		healtyBarLength = Screen.width / 4;
	}

	// Update is called once per frame
	void Update () {
		AddJustCurrentHealty (0);
	}

	void OnGUI(){
		GUI.Box (new Rect (250, 100, 35, 35), enemy3, style);
		GUI.Box (new Rect (290, 100, healtyBarLength, 20), curHealty + "/" + maxHealth);
	}


	public void AddJustCurrentHealty(int adj){
		curHealty += adj;

		if(curHealty < 0)
			curHealty = 0;

		if (curHealty > maxHealth)
			curHealty = maxHealth; 

		if (maxHealth < 1)
			maxHealth = 1;

		healtyBarLength = (Screen.width / 4) * (curHealty / (float)maxHealth);
	}
}
