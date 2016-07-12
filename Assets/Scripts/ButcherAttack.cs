using UnityEngine;
using System.Collections;

public class ButcherAttack : MonoBehaviour {
	public GameObject player;
	//need a condition statement to apply to different characters.
	private float dist;
	public Animator anim;
	private float nextActionTime = 0.0f;
	public float period = 0.1f;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		float dist = Vector3.Distance(player.transform.position, transform.position);
		if (Time.time > nextActionTime ) {
			nextActionTime += period;
			if (dist >= 20) {
				anim.Play ("Attack", -1, 0f);

		}
		//print("Distance to other: " + dist);
		/*if (dist >= 20) {
			anim.Play ("Attack", -1, 0f);
		}
*/
		/*if (Input.GetKeyDown("5")) {
			print ("5 is pressed");
			anim.Play ("HumanoidWalk",0,0f);
		}
		*/

	}
		
}

