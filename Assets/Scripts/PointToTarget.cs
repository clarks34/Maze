using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PointToTarget : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    [SerializeField]
    private Transform key;

    [SerializeField]
    private Transform padLock;

    [SerializeField]
    private TargetStateSO targetStateSO;

    private void OnEnable()
    {
        if (targetStateSO == null) return;
        targetStateSO.TargetChangeEvent.AddListener(onTargetChange);
        onTargetChange(targetStateSO.target);
    }

    private void OnDisable()
    {
        if(targetStateSO == null) return;
        targetStateSO.TargetChangeEvent.RemoveListener(onTargetChange);
    }

    // Update is called once per frame
    void Update()
    {
        if(target != null)
            transform.LookAt(target);
        Debug.DrawRay(transform.position, target.position);
    }

    public void onTargetChange(TargetStates newTarget)
    {
        switch (newTarget)
        {
            case TargetStates.Key:
                target = key;
                break;
            case TargetStates.PadLock:
                target = padLock;
                break;
            default:
                target = key;
                break;
        }
    }
}
