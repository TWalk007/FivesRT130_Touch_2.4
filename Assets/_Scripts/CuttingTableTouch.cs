using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingTableTouch : MonoBehaviour {

	public GameObject frontDoors;
	public ExploreControllerTouch exploreControllerTouch;

    public bool canSelect = false;

    private void OnMouseDown()
    {
        if (canSelect)
        {
            exploreControllerTouch.myState = ExploreControllerTouch.States.cuttingTable;
        }
    }

}
