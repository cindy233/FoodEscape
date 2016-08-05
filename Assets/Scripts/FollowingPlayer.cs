using UnityEngine;
using System.Collections;

public class FollowingPlayer : MonoBehaviour {

	public GameObject player;
	public float maxSpeed;
	private Vector3 offset;
	private Vector3 startPosition;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position = player.transform.position + offset;

		if(transform.position.x <= -122)
			transform.position = player.transform.position - offset;
		
		transform.position = new Vector3(transform.position.x, startPosition.y + Mathf.Sin(Time.time * maxSpeed), transform.position.z);

	}

}
