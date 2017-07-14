using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftDoorOpen : MonoBehaviour
{


    public float closedAngle = -180f;
    public float openedAngle = -70f;
    public float doorOpenTime = 1.5f;

    public bool isDoorOpened = false;

    private void OnMouseDown()
    {
        if (!isDoorOpened)
        {
            iTween.RotateTo(gameObject, iTween.Hash("y", openedAngle, "easeType", "easeInOutQuad", "time", doorOpenTime));
            isDoorOpened = true;
        }
        else if (isDoorOpened)
        {
            iTween.RotateTo(gameObject, iTween.Hash("y", closedAngle, "easeType", "easeInOutQuad", "time", doorOpenTime));
            isDoorOpened = false;
        }
    }
}
