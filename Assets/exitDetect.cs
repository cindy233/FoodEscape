using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class exitDetect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "Player")
		{
			SceneManager.LoadScene ("Win Scene");
		}
	}
}
