using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class selection : MonoBehaviour {

	public int selectedCharacter = 0;
	private bool select;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0))
		{
		RaycastHit hitInfo = new RaycastHit ();
		bool hit = Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hitInfo);

			if (hit) {
				/*
			if (hitInfo.collider.name == "taichi1") {

				Debug.Log ("TaiCHI1 is selected");
				selectedCharacter = 1;
			
			}
*/
				switch (hitInfo.collider.name) {

				case "taichi1":
					Debug.Log ("TaiCHI1 is selected");
					selectedCharacter = 1;
					break;
				case "unitychan":
					Debug.Log ("Unity Chan is selected");
					selectedCharacter = 2;
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
				SceneManager.LoadScene ("SimulateFight");
			}
		}

	}

	void OnGUI(){
		// add a new Select button
		if (GUI.Button (new Rect (Screen.width - 100, 110, 80, 20), "Select")) {
			select = true;
		}

	}
}
