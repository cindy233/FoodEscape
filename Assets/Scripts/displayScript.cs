using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class displayScript : MonoBehaviour {

	public Text scriptDisplay;
	public TextAsset wholeScript;
	public GameObject btn;
	private int word = 0;
	private string[] letters;
	private bool addwords = false;

	// Use this for initialization
	void Start () {

		letters = wholeScript.text.Split (' ');
		scriptDisplay.text = letters [0];
		word = 1;
		StartCoroutine (slower ());
		btn.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
	
		if (word < letters.Length && addwords) {
		
			scriptDisplay.text += " " + letters [word++];
			StartCoroutine (slower ());
		
		} else if (word >= letters.Length)
			btn.SetActive (true);
	}
	IEnumerator slower(){
	
		addwords = false;
		yield return new WaitForSeconds(0.1f);
		addwords = true;
	}
}
