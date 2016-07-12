using UnityEngine;
using System.Collections;

public class ButcherAttack : MonoBehaviour {
	public GameObject player;
	//need a condition statement to apply to different characters.
	private float dist;
	public Animator anim;
	private float nextActionTime = 0.1f;
	public float period = 3f;

	//private Transform myTransform;

	void Awake(){
		//myTransform = transform;
	}

	// Use this for initialization
	void Start () {

		//GameObject go = GameObject.FindGameObjectWithTag ("Player");
		//target = go.transform;

		anim = GetComponent<Animator> ();
	}
	
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
}