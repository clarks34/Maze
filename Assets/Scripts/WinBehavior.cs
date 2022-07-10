using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class WinBehavior : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> WinGameObjects;

    private void Start()
    {
        foreach (GameObject gb in WinGameObjects)
        {
            gb.SetActive(false);
        }
    }
    public void OnTeleport(TeleportingEventArgs args)
    {
        foreach (GameObject gb in WinGameObjects)
        {
            gb.SetActive(true);
        }
    }
}
