using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class USFlagTouch : MonoBehaviour {

	public ExploreControllerTouch exploreController;
	public ExploreSceneAudio exploreAudio;

    private void OnMouseDown()
    {
        exploreAudio.selectedClip = exploreAudio.audioClip[5];
        exploreController.myState = ExploreControllerTouch.States.usFlag;
    }    
}
