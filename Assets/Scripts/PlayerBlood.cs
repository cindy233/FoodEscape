using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerBlood : MonoBehaviour {

	public int maxHealth = 100;
	public int curHealty = 100;

	public float healtyBarLength;

	public Texture player1;
	public Texture potato1;
	public Texture potato2;
	//GUIContent content;
	GUIStyle style = new GUIStyle();

	// Use this for initialization
	void Start () {
		//content = new GUIContent(player1, curHealty + "/" + maxHealth);
		healtyBarLength = Screen.width / 4;
	}

	// Update is called once per frame
	void Update () {
		AddJustCurrentHealty (0);
		if(curHealty == 0 || curHealty <0)
			SceneManager.LoadScene ("Game Over");
	}

	void OnGUI(){
		GUI.Box (new Rect (10, 10, 35, 35), player1, style);
		GUI.Box (new Rect (50, 20, healtyBarLength, 20), curHealty + "/" + maxHealth);
		GUI.Box (new Rect (10, 50, 35, 35), potato1, style);
		GUI.Box (new Rect (50, 60, healtyBarLength, 20), curHealty + "/" + maxHealth);
		GUI.Box (new Rect (10, 90, 35, 35), potato2, style);
		GUI.Box (new Rect (50, 100, healtyBarLength, 20), curHealty + "/" + maxHealth);
	}


	public void AddJustCurrentHealty(int adj){
		curHealty += adj;

		if (curHealty < 0) 
			curHealty = 0;

		if (curHealty > maxHealth)
			curHealty = maxHealth; 

		if (maxHealth < 1)
			maxHealth = 1;

		healtyBarLength = (Screen.width / 4) * (curHealty / (float)maxHealth);
	}
}
