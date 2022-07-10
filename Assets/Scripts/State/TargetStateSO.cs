using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "TargetStateSO", menuName ="Scriptable Objects/Target State SO")]
public class TargetStateSO : ScriptableObject
{
    [SerializeField]
    private TargetStates defaultTarget;

    [System.NonSerialized]
    public TargetStates target;

    [System.NonSerialized]
    public UnityEvent<TargetStates> TargetChangeEvent;

    private void OnEnable()
    {
        target = defaultTarget;

        if(TargetChangeEvent == null)
        {
            TargetChangeEvent = new UnityEvent<TargetStates>();
        }
    }

    private void OnDestroy()
    {
        if (TargetChangeEvent != null)
        {
            TargetChangeEvent.RemoveAllListeners();
        }
    }

    public void ChangeTarget(TargetStates newTarget)
    {
        if (newTarget == target) return;
        
        target = newTarget;
        TargetChangeEvent.Invoke(target);


    }


}
