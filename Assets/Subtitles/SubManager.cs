using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class SubManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 vHeadPos = Camera.main.transform.position;
        Vector3 vGazeDir = Camera.main.transform.forward;
        transform.position = (vHeadPos + vGazeDir * 2.0f) + new Vector3(0.0f, -.8f, 0.0f);
        Vector3 vRot = Camera.main.transform.eulerAngles; vRot.z = 0;
        transform.eulerAngles = vRot;
    }
}
