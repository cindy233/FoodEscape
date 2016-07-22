using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {
	public Animator anim;
	// Use this for initialization

	public Transform target1;
	public Transform target2;
	public Transform target3;

	public float attackTimer;
	public float coolDowm;

	void Start () {
		anim = GetComponent<Animator> ();

		attackTimer = 0;
		coolDowm = 1f;

		GameObject go1 = GameObject.Find ("Enemy1");
		target1 = go1.transform;

		GameObject go2 = GameObject.Find ("Enemy2");
		target2 = go2.transform;

		GameObject go3 = GameObject.Find ("Enemy3");
		target3 = go3.transform;
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
				Attack (-5);
				attackTimer = coolDowm;
			}
		}
		if (Input.GetKeyDown("2")) {
			print ("2 is pressed");
			anim.Play ("kick_24",0,0f);
			if (attackTimer == 0) {
				Attack (-10);
				attackTimer = coolDowm;
			}
		}
		if (Input.GetKeyDown("3")) {
			print ("3 is pressed");
			anim.Play ("kick_21",0,0f);
			if (attackTimer == 0) {
				Attack (-15);
				attackTimer = coolDowm;
			}
		}

		//for debugging use
		if (Input.GetKeyDown("4")) {
			print ("4 is pressed");
			anim.Play ("damage_22",0,0f);
			Attack (0);

		}
	}
		

	private void Attack(int adj){

		float distance1 = Vector3.Distance(target1.transform.position, transform.position);
		Vector3 dir1 = (target1.transform.position - transform.position).normalized;
		float direction1 = Vector3.Dot(dir1, transform.forward);
		if (distance1 < 20f)
		if (direction1 > 0) {
			Enemy1Blood eh1 = (Enemy1Blood)target1.GetComponent ("Enemy1Blood");
			eh1.AddJustCurrentHealty (adj);

		}


		float distance2 = Vector3.Distance(target2.transform.position, transform.position);
		Vector3 dir2 = (target2.transform.position - transform.position).normalized;
		float direction2 = Vector3.Dot(dir2, transform.forward);
		if (distance2 < 20f)
		if (direction2 > 0) {
			Enemy2Blood eh2 = (Enemy2Blood)target2.GetComponent ("Enemy2Blood");
			eh2.AddJustCurrentHealty (adj);
		}

		float distance3 = Vector3.Distance(target3.transform.position, transform.position);
		Vector3 dir3 = (target3.transform.position - transform.position).normalized;
		float direction3 = Vector3.Dot(dir3, transform.forward);
		if (distance3 < 20f)
		if (direction3 > 0) {
			Enemy3Blood eh3 = (Enemy3Blood)target3.GetComponent ("Enemy3Blood");
			eh3.AddJustCurrentHealty (adj);
		}


	} 
}
