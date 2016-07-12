using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {

	public GameObject target;
	public float attackTimer;
	public float coolDowm;

	Animator anim;
	int AirBorne = Animator.StringToHash("AirBorne");
	int Grounded = Animator.StringToHash("Grounded");
	int Crouching = Animator.StringToHash("Crouching");
	

	// Use this for initialization
	void Start () {
		attackTimer = 0;
		coolDowm = 2.0f;

		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (attackTimer > 0)
			attackTimer -= Time.deltaTime;

		if (attackTimer < 0)
			attackTimer = 0;

		if (Input.GetKeyUp(KeyCode.F)) {
			if (attackTimer == 0) {
				Attack ();
				attackTimer = coolDowm;
			}
		}

		if (Input.GetKeyUp(KeyCode.C)) {
			anim.SetTrigger (Crouching);
		}
	}

	private void Attack(){
		float distance = Vector3.Distance(target.transform.position, transform.position);

		Vector3 dir = (target.transform.position - transform.position).normalized;

		float direction = Vector3.Dot(dir, transform.forward);

		if (distance < 20f)
		    if (direction > 0) {
			    Enemy1Blood eh1 = (Enemy1Blood)target.GetComponent ("Enemy1Blood");
			    eh1.AddJustCurrentHealty (-10);
			    Enemy2Blood eh2 = (Enemy2Blood)target.GetComponent ("Enemy2Blood");
			    eh2.AddJustCurrentHealty (-10);
			    Enemy3Blood eh3 = (Enemy3Blood)target.GetComponent ("Enemy3Blood");
			    eh3.AddJustCurrentHealty (-10);
		  
		}
 	} 
}
