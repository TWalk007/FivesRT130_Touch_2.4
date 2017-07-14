using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class USFlagTouch : MonoBehaviour {

	public float gazeActivationTime = 1.25f;
	public ExploreControllerTouch exploreController;
	public ExploreSceneAudio exploreAudio;

	private float timeElapsed;
	private bool isEntered = false;

	void Update () {
		if (isEntered) {
			USFlagVO ();
		} else {
			timeElapsed = 0;
		}
	}

	public void USFlagVO(){
		timeElapsed += Time.deltaTime;

		if (timeElapsed >= gazeActivationTime) {
			timeElapsed = 0;
			exploreAudio.selectedClip = exploreAudio.audioClip [5];
			exploreController.myState = ExploreControllerTouch.States.usFlag;
			isEntered = false;
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
