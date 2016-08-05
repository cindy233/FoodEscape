using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class enemyDialogue : MonoBehaviour {

	private GameObject player;
	private bool show = false;
	private bool display = true;
	private GUIStyle titleStyle;
	private GUIStyle normalText;
	public Texture enterBtn;
	public Texture enemyPic;

	// Use this for initialization
	void Start () {

		player = GameObject.Find ("FPSController");
		PlayerPrefs.SetInt("enemyDialogue",1);

	}

	// Update is called once per frame
	void Update () {

		// Calculat the distance between the user and the butcher
		float dist = Vector3.Distance (transform.position, player.transform.position);

		if (display) {
			
			if (dist <= 15) {
				show = true;
				display = false;
			} else
				show = false;
	
		}
		if (Input.GetKeyDown(KeyCode.Return) && show) {

			show = false;
			PlayerPrefs.SetInt("enemyDialogue",3);

		}

		int enemyPressed = PlayerPrefs.GetInt ("enemyDialogue");
		if (enemyPressed==3)
			SceneManager.LoadScene("Level1");
	}

	void OnGUI(){

		titleStyle = new GUIStyle ();
		normalText = new GUIStyle ();
		Font beautyFont = (Font)Resources.Load ("remachine", typeof(Font));
		titleStyle.font = beautyFont;
		titleStyle.normal.textColor = Color.white;
		titleStyle.fontStyle = FontStyle.Bold;

		normalText.font = beautyFont;
		normalText.normal.textColor = Color.white;
		normalText.fontStyle = FontStyle.Bold;

		if(show)
		{
			int middleX = (Screen.width - 100)/2;
			int middleY = (Screen.height - 100)/2;
			GUI.Box (new Rect (middleX, middleY, 280, 120),"");
			GUI.Label (new Rect (middleX+10, middleY+10,100,20),"Butcher",titleStyle);
			GUI.Label (new Rect (middleX+80, middleY+28,100,20),"Little kid, you want to save \nthose food?",normalText);
			GUI.Label (new Rect (middleX+80, middleY+60,100,20),"Let's have a battle!",normalText);
			GUI.DrawTexture (new Rect (middleX+210, middleY+80,60,30),enterBtn);
			GUI.DrawTexture (new Rect (middleX+10, middleY+30, 70, 80),enemyPic);
			PlayerPrefs.SetInt("enemyDialogue",0);


		}
		else
			PlayerPrefs.SetInt("enemyDialogue",1);


	}

}
