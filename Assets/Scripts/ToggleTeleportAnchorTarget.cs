using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTeleportAnchorTarget : MonoBehaviour
{
    public Transform orginalPosition;
    public Transform secondPosition;

    private bool isOnOriginalPosition = true;

    
    public void OnTeleportTrigger()
    {
        Transform targetTransform = isOnOriginalPosition ? secondPosition : orginalPosition;
        transform.position = targetTransform.position;
        transform.rotation = targetTransform.rotation;

        isOnOriginalPosition = !isOnOriginalPosition;
    } 
   
}
