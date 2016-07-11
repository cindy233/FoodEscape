using UnityEngine;
using System.Collections;

public class TaichiAttack : MonoBehaviour {
	public Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("1")) {
			print ("1 is pressed");
			anim.Play ("punch_21",0,0f);
		}
		if (Input.GetKeyDown("2")) {
			print ("2 is pressed");
			anim.Play ("kick_24",0,0f);
		}
		if (Input.GetKeyDown("3")) {
			print ("3 is pressed");
			anim.Play ("kick_21",0,0f);
		}

		//for debugging use
		if (Input.GetKeyDown("4")) {
			print ("4 is pressed");
			anim.Play ("damage_22",0,0f);
		}
	}
}
