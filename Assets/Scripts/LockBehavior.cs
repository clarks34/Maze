using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockBehavior : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> disappearables;

    
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Key"))
        {
            foreach(GameObject gb in disappearables)
            {
                gb.SetActive(false);
            }
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
    }


}
