using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class selection : MonoBehaviour {

	public int selectedCharacter = 0;
	private bool select;
	private GameObject characters;

	// Use this for initialization
	void Start () {
	
		characters = GameObject.Find ("CharacterSet");
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0))
		{
		RaycastHit hitInfo = new RaycastHit ();
		bool hit = Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hitInfo);

			if (hit) {

				switch (hitInfo.collider.name) {

				case "taichi1":
					Debug.Log ("TaiCHI1 is selected");
					selectedCharacter = 1;
					Rotate (240);
					break;
				case "unitychan":
					Debug.Log ("Unity Chan is selected");
					selectedCharacter = 2;
					Rotate (0);
					break;
				case "querychan":
					Debug.Log ("Query Chan is selected");
					selectedCharacter = 3;
					break;
				default:
				//selectedCharacter = 0;
					break;
				
				}

			}
		}
		if (select) {
			if (selectedCharacter == 0) {
				select = false;
				// TODO: some warning message should be prompted up such as "No character is being selected"
			} else {
				PlayerPrefs.SetInt("selectedCharacter",selectedCharacter);
				SceneManager.LoadScene ("BattleScene");
			}
		}

	}

	void OnGUI(){
		// add a new Select button
		if (GUI.Button (new Rect (Screen.width - 100, 110, 80, 20), "Select")) {
			select = true;
		}

	}

	void Rotate(float target){

		float angle = Mathf.MoveTowardsAngle(characters.transform.eulerAngles.y, target, 145.0F * Time.deltaTime);
		transform.eulerAngles = new Vector3(0, angle, 0);
	}
}
