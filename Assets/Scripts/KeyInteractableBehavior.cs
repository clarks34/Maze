using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class KeyInteractableBehavior : MonoBehaviour
{
    [SerializeField]
    private TargetStateSO targetStateSO;

     public void onGrab(SelectEnterEventArgs args)
    {
       
        if(args.interactableObject.transform.CompareTag("Key"))
        {
            targetStateSO.ChangeTarget(TargetStates.PadLock);
        } else
        {
            targetStateSO.ChangeTarget(TargetStates.Key);
        }
    }

    public void onRelease(SelectExitEventArgs args)
    {
        targetStateSO.ChangeTarget(TargetStates.Key);
    }
}
