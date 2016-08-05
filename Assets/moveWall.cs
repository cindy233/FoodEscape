using UnityEngine;
using System.Collections;

public class moveWall : MonoBehaviour {

	public float maxSpeed;
	public string direction="z";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(direction=="z")
			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + Mathf.Sin(Time.time * maxSpeed));
		if(direction=="y")
			transform.position = new Vector3(transform.position.x, transform.position.y+ Mathf.Sin(Time.time * maxSpeed), transform.position.z );
		
	}
}
