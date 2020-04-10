using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAnimator : MonoBehaviour {

	public Animator garyAnimation;

	private void OnMouseDown(){
		garyAnimation.SetTrigger ("Wave");
	}

	private void OnEnable(){
		garyAnimation.ResetTrigger ("Wave");
	}
}
