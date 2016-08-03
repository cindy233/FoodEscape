using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameControl : MonoBehaviour {

	public int total_food = 0;
	public int food_remain = 0;
	public Text foodTitle;
	public Text gameStatus;
	public GameObject exit;
	// Use this for initialization
	void Start () {
	
		exit.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
		foodTitle.text = "Food Remain:" + food_remain.ToString("D2") + "/" + total_food.ToString("D2");

		if (food_remain == 0) {
			exit.SetActive(true);
			gameStatus.text = "Exit is unlocked! Run!";
		}
	}
}
