using UnityEngine;
using System.Collections;

public class ButcherAttack : MonoBehaviour {
	public GameObject player;
	//need a condition statement to apply to different characters.
	private float dist;
	public Animator anim;
	private float nextActionTime = 0.1f;
	public float period = 3f;

	private Transform myTransform;
	public Transform target;
	//public Transform target1;
	public int moveSpeed;
	public int rotationSpeed;
	public int minDistance;
	public int maxDistance;

	void Awake(){
		myTransform = transform;
	}

	// Use this for initializat
	void Start () {

		//GameObject go = GameObject.FindGameObjectWithTag ("Player");
		//target = go.transform;
		GameObject go = GameObject.FindGameObjectWithTag ("Player");
		target = go.transform;

		anim = GetComponent<Animator> ();
	}

	/*
	// Update is called once per frame
	void Update () {
		float dist = Vector3.Distance (player.transform.position, transform.position);
		if (Time.time > nextActionTime) {
			nextActionTime = Time.time + period;
			if (dist <= 15) {
				anim.Play ("Attack", -1, 0f);

				PlayerBlood eh = (PlayerBlood)player.GetComponent ("PlayerBlood");
				eh.AddJustCurrentHealty (-10);

			}
			else if ((15 < dist) && (dist <= 120)) {
				anim.Play ("HumanoidWalk", 0, 0f);
			} 
			else if (dist > 120) {
				anim.Play ("Default", 0, 0f);
			}

		
		}
	}
	*/

	void Update () {

		float distance = Vector3.Distance(target.transform.position, myTransform.position);
		if (distance <= 20f) {
			moveSpeed = 0;
			rotationSpeed = 25;
			if (Time.time > nextActionTime) {
				nextActionTime = Time.time + period  ;
				anim.Play ("Attack", -1, 0f);
				PlayerBlood eh = (PlayerBlood)target.GetComponent ("PlayerBlood");
				eh.AddJustCurrentHealty (-10);
				myTransform.rotation = Quaternion.Slerp (myTransform.rotation, Quaternion.LookRotation (target.position - myTransform.position), rotationSpeed * Time.deltaTime);
				myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;

			}

		} else if (20f < distance && (distance <= 120f)) {
			moveSpeed = 20;
			rotationSpeed = 20;
			if (Time.time > nextActionTime) {
				nextActionTime = Time.time + period - 0.6f;
				anim.Play ("HumanoidWalk", 0, 0f);
			}
			myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
			myTransform.rotation = Quaternion.Slerp (myTransform.rotation, Quaternion.LookRotation (target.position - myTransform.position), rotationSpeed * Time.deltaTime);
			//man.SetDestination (target.position);

		} else if (120f < distance) {
			if (Time.time > nextActionTime) {
				nextActionTime = Time.time + period -1;
				anim.Play ("Default", 0, 0f);
			}
		}

	}
}