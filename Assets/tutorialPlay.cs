using UnityEngine;
using System.Collections;

public class tutorialPlay : MonoBehaviour {
	public Animator anim;
	// Use this for initialization

	public GameObject player;
	public GameObject go4;
	public GameObject go5;

	public float attackTimer;
	public float coolDowm;

	void Start () {
		anim = GetComponent<Animator> ();

		attackTimer = 0;
		coolDowm = 1f;


	}

	// Update is called once per frame
	void Update () {

		if (attackTimer > 0)
			attackTimer -= Time.deltaTime;

		if (attackTimer < 0)
			attackTimer = 0;

		if (Input.GetKeyDown("1")) {
			print ("1 is pressed");
			anim.Play ("punch_21",0,0f);
			if (attackTimer == 0) {
				attackTimer = coolDowm;
			}
		}
		if (Input.GetKeyDown("2")) {
			print ("2 is pressed");
			anim.Play ("kick_24",0,0f);
			if (attackTimer == 0) {
				attackTimer = coolDowm;
			}
		}
		if (Input.GetKeyDown("3")) {
			print ("3 is pressed");	
			anim.Play ("kick_21",0,0f);
			if (attackTimer == 0) {
				attackTimer = coolDowm;
			}
		}

		//for debugging use
		if (Input.GetKeyDown("4")) {
			print ("4 is pressed");
			anim.Play ("damage_22",0,0f);
		}
	}





}
