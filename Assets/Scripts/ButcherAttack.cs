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


		anim = GetComponent<Animator> ();
	}


	void Update () {

		float distance = Vector3.Distance(player.transform.position, myTransform.position);
		if (distance <= 20f) {
			moveSpeed = 0;
			rotationSpeed = 25;
			if (Time.time > nextActionTime) {
				nextActionTime = Time.time + period  ;
				anim.Play ("Attack", -1, 0f);
				PlayerBlood eh = (PlayerBlood)player.GetComponent ("PlayerBlood");
				eh.AddJustCurrentHealty (-10);
				myTransform.rotation = Quaternion.Slerp (myTransform.rotation, Quaternion.LookRotation (player.transform.position - myTransform.position), rotationSpeed * Time.deltaTime);
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
			myTransform.rotation = Quaternion.Slerp (myTransform.rotation, Quaternion.LookRotation (player.transform.position - myTransform.position), rotationSpeed * Time.deltaTime);
			//man.SetDestination (target.position);

		} else if (120f < distance) {
			if (Time.time > nextActionTime) {
				nextActionTime = Time.time + period -1;
				anim.Play ("Default", 0, 0f);
			}
		}

	}
}