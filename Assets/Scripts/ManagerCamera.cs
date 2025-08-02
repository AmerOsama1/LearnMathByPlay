using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class ManagerCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            CameraShaker.Instance.ShakeOnce(4f,4f,.1f,1f);
        
    }
}
