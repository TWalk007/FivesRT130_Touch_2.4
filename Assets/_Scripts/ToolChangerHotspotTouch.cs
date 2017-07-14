using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolChangerHotspotTouch : MonoBehaviour {

	public float gazeActivationTime = 1.25f;
	public ExploreControllerTouch exploreControllerTouch;

	private float timeElapsed;
	private bool isEntered = false;

	void Update () {
		if (isEntered) {
			ActivateTC ();
		}
	}

	void ActivateTC(){
		timeElapsed += Time.deltaTime;
		if (timeElapsed >= gazeActivationTime) {
			timeElapsed = 0;
			exploreControllerTouch.myState = ExploreControllerTouch.States.toolChanger;
		}
	}

	public void OnPointerEnter (){
		isEntered = true;
	}

	public void OnPointerExit (){
		isEntered = false;
		timeElapsed = 0;
	}

}
