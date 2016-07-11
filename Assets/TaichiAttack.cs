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
	}
}
