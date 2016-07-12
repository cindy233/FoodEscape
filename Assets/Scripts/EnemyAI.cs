using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	public Transform target;
	public int moveSpeed;
	public int rotationSpeed;
	public int minDistance;
	public int maxDistance;

	private Transform myTransform;

	public Animator anim;

	void Awake(){
		myTransform = transform;
	}

	// Use this for initialization
	void Start () {
		GameObject go = GameObject.FindGameObjectWithTag ("Player");
		target = go.transform;

		//maxDistance = 100;
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {


		float distance = Vector3.Distance(target.transform.position, myTransform.position);

		if (distance <= 15f) {
			moveSpeed = 0;
			rotationSpeed = 0;
		} else if (15f <= distance && (distance <=120f)) {
			moveSpeed = 20;
			rotationSpeed = 10;
			//anim.Play ("Attack", -1, 0f);
		}else if (120f<distance){
			moveSpeed = 0;
			rotationSpeed = 0;
		}
		//Debug.DrawLine(target.position, myTransform.position, Color.red);
		//look at target
		myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);

		//if (Vector3.Distance (target.position, myTransform.position) > maxDistance) {

			myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;

	}
}
 