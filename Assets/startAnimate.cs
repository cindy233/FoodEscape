using UnityEngine;
using System.Collections;

// Require these components when using this script
[RequireComponent(typeof(Animator))]

public class startAnimate : MonoBehaviour
{

	private Animator anim;						
	private AnimatorStateInfo currentState;		
	private AnimatorStateInfo previousState;	


	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator> ();
		currentState = anim.GetCurrentAnimatorStateInfo (0);
		previousState = currentState;
		anim.SetBool ("Next", true);

	}

	// Update is called once per frame
	void  Update ()
	{
			currentState = anim.GetCurrentAnimatorStateInfo (0);
		if (previousState.fullPathHash != currentState.fullPathHash) {
			anim.SetBool ("Next", false);
			previousState = currentState;				
		} 
	
	}

}