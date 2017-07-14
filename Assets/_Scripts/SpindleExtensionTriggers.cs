using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpindleExtensionTriggers : MonoBehaviour {
	
	public ExploreControllerTouch exploreControllerTouch;

	public bool audioHasPlayed = false;

	void StartNextAudio (){
		if (!audioHasPlayed) {
			StartCoroutine (exploreControllerTouch.VODelay ());
			audioHasPlayed = true;
		}
	}
}
