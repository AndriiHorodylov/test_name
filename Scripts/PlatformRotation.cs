using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRotation : MonoBehaviour
{
    public float RotationSpeed;
    
    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(0, RotationSpeed, 0);
    }
}
