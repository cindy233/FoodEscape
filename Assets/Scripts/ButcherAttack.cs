using UnityEngine;
using System.Collections;

public class ButcherAttack : MonoBehaviour {
	public GameObject player;
	//need a condition statement to apply to different characters.
	private float dist;
	public Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		float dist = Vector3.Distance(player.transform.position, transform.position);
		//print("Distance to other: " + dist);
		if (dist >= 20) {
			anim.Play ("Attack", -1, 0f);
		}

	}
		
}

