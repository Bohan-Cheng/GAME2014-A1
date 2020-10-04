using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
