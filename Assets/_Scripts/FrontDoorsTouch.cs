using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontDoorsTouch : MonoBehaviour {

	public bool frontDoorsOpen = false;

	public GameObject audioController;
	public GameObject leftDoor;
	public GameObject rightDoor;
	public GameObject cuttingTable;

	public ExploreControllerTouch exploreControllerTouch;

	private bool leftDoorOpen = false;
	private bool rightDoorOpen = false;
	private bool hasfrontLoadingPlayed = false;

	void Update () {
		FrontDoorStateUpdate ();
		CanAssemblyVOPlay ();
		AssemblyVOReset ();
	}

	private void CanAssemblyVOPlay(){
		if (frontDoorsOpen && !hasfrontLoadingPlayed) {
			hasfrontLoadingPlayed = true;
			exploreControllerTouch.myState = ExploreControllerTouch.States.frontLoading;
		}		
	}

	private bool FrontDoorStateUpdate(){
		leftDoorOpen = leftDoor.GetComponent<LeftDoorOpen>().isDoorOpened;
		rightDoorOpen = rightDoor.GetComponent<RightDoorOpen>().isDoorOpened;

		if (leftDoorOpen && rightDoorOpen) {
			return frontDoorsOpen = true;
		} else {
			return frontDoorsOpen = false;
		}
	}

	public void AssemblyVOReset (){
		if (!frontDoorsOpen && hasfrontLoadingPlayed) {
			exploreControllerTouch.hasFrontLoadingPlayed = false;
			hasfrontLoadingPlayed = false;
            cuttingTable.GetComponent<CuttingTableTouch>().canSelect = false;
            cuttingTable.GetComponentInChildren<HotspotShaderAdjustment>().enabled = false;
            exploreControllerTouch.particleGlowTable.SetActive(false);
        }
	}

}
