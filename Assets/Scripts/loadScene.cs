using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour {

	public string sceneName = "Start";
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Return)) {

			onClick ();

		}
	}

	public void onClick(){
	
		SceneManager.LoadScene (sceneName);
	}

}
