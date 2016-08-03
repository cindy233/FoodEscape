using UnityEngine;
using System.Collections;

public class FruitBehaviour : MonoBehaviour {

	private gameControl gc;

	// Use this for initialization
	void Start () {

		gc = GameObject.Find ("GameControl").GetComponent<gameControl>();
		gc.total_food++;
		gc.food_remain++;


	}

	// Update is called once per frame
	void Update () {

		transform.Rotate (0, 0, Time.deltaTime * 50.0f);

	}

	void OnCollisionEnter(Collision col){

		if (col.gameObject.tag == "Player") {
			gc.food_remain--;
			Destroy (gameObject);
		}
	}
}
