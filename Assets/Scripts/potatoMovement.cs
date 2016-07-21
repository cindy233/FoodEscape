using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class potatoMovement : MonoBehaviour {

	private Vector3 startPosition;
	public float maxSpeed;
	private GUIStyle titleStyle;
	private GUIStyle normalText;
	public Texture enterBtn;
	public Texture potatoPic;
	private bool show = true;

	// Use this for initialization
	void Start () {
	
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position = new Vector3(transform.position.x, startPosition.y + Mathf.Sin(Time.time * maxSpeed), transform.position.z);

		if (Input.GetKeyDown(KeyCode.Return) && show) {

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

		if (show) {
			int middleX = (Screen.width - 100) / 2 + 50;
			int middleY = (Screen.height - 100) / 2 + 20;
			GUI.Box (new Rect (middleX, middleY, 280, 120), "");
			GUI.Label (new Rect (middleX + 10, middleY + 10, 100, 20), "Potato", titleStyle);
			GUI.Label (new Rect (middleX + 70, middleY + 35, 100, 20), "Finally escaped successfully!!!", normalText);
			GUI.Label (new Rect (middleX + 70, middleY + 55, 100, 20), "Thanks for helping me so much!", normalText);
			GUI.Label (new Rect (middleX + 70, middleY + 75, 100, 20), "You are my hero!", normalText);
			GUI.DrawTexture (new Rect (middleX + 210, middleY + 90, 60, 30), enterBtn);
			GUI.DrawTexture (new Rect (middleX + 10, middleY + 30, 50, 70), potatoPic);
		} else if (!show) {
		
			if (GUI.Button (new Rect (Screen.width - 100, 110, 80, 20), "Restart")) {

				SceneManager.LoadScene ("Start");
			}
		
		}

	}
}
