using UnityEngine;
using System.Collections;

public class Enemy1Blood : MonoBehaviour {

	public int maxHealth = 100;
	public int curHealty = 100;

	public float healtyBarLength;
	public float fixedMaxBarLength;
	public Texture enemy1;
	GUIStyle style = new GUIStyle();
	public Texture2D bloodBar;

	// Use this for initialization
	void Start () {
		healtyBarLength = Screen.width / 4;
		fixedMaxBarLength = Screen.width / 4;
	}

	// Update is called once per frame
	void Update () {
		AddJustCurrentHealty (0);
	}

	void OnGUI(){
		GUI.Box (new Rect (250, 20, 35, 35), enemy1, style);
		GUI.Box (new Rect (290, 20, fixedMaxBarLength, 20),curHealty + "/" + maxHealth);
		GUI.Box (new Rect (290, 20, healtyBarLength, 20), "");
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
