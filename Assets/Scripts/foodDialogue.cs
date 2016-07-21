using UnityEngine;
using System.Collections;

public class foodDialogue : MonoBehaviour {

	private GameObject player;
	private bool show = false;
	private bool display = true;
	private int enemyDialogue = 1;
	private GUIStyle titleStyle;
	private GUIStyle normalText;
	public Texture enterBtn;
	public Texture potatoPic;

	// Use this for initialization
	void Start () {

		player = GameObject.Find ("FPSController");

	}

	// Update is called once per frame
	void Update () {

		// Calculate the distance between the user and the potato
		float dist = Vector3.Distance (transform.position, player.transform.position);

		enemyDialogue = PlayerPrefs.GetInt ("enemyDialogue");

		if (display) {

			if (dist <= 15) {
				if (enemyDialogue == 0)
					show = false;
				else {
					show = true;
					display = false;
				}
			} else
				show = false;

		}
		if (Input.GetKeyDown(KeyCode.Return)) {

			show = false;
		}


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
			GUI.Label (new Rect (middleX+10, middleY+10,100,20),"Potato",titleStyle);
			GUI.Label (new Rect (middleX+70, middleY+35,100,20),"Please help me!!!",normalText);
			GUI.Label (new Rect (middleX+70, middleY+55,100,20),"The Butcher is going to kill me!",normalText);
			GUI.DrawTexture (new Rect (middleX+210, middleY+80,60,30),enterBtn);
			GUI.DrawTexture (new Rect (middleX+10, middleY+30, 50, 70),potatoPic);

		}


	}

}
