// GameController.cs
// Student Name: Bohan Cheng
// Student #: 101130599
// Last Modified: 2020/10/25
// Description: This script logs out different device orientations
// History: None

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        switch (Input.deviceOrientation)
        {
            case DeviceOrientation.Unknown:
                Debug.Log("Unknown");
                break;
            case DeviceOrientation.Portrait:
                Debug.Log("Protrait");
                break;
            case DeviceOrientation.PortraitUpsideDown:
                Debug.Log("PortraitUpsideDown");
                break;
            case DeviceOrientation.LandscapeLeft:
                Debug.Log("LandscapeLeft");
                break;
            case DeviceOrientation.LandscapeRight:
                Debug.Log("LandscapeRight");
                break;
            case DeviceOrientation.FaceUp:
                Debug.Log("FaceUp");
                break;
            case DeviceOrientation.FaceDown:
                Debug.Log("FaceDown");
                break;
            default:
                Debug.Log("Unknown");
                break;
        }
    }
}
