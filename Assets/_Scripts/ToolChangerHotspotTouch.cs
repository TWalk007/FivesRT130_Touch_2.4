using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolChangerHotspotTouch : MonoBehaviour {

	public ExploreControllerTouch exploreControllerTouch;


	private void OnMouseDown()
    {
		exploreControllerTouch.myState = ExploreControllerTouch.States.toolChanger;
	}

}
