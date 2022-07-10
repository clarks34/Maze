using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingBehavior : MonoBehaviour
{
    [SerializeField]
    private Vector3 rotationAngle;
    [SerializeField]
    private float rotationSpeed;




    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationAngle * rotationSpeed * Time.deltaTime);

    }
}
