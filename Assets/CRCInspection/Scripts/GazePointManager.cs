using Microsoft.MixedReality.Toolkit;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GazePointManager : MonoBehaviour
{
    const float defaultDistanceInMeters = 2f;
    public TextMeshPro Text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CoreServices.InputSystem.EyeGazeProvider.IsEyeTrackingEnabled) {
            Text.text = CoreServices.InputSystem.EyeGazeProvider.HitPosition.ToString();
            
            
            // Show the object at the hit position of the user's eye gaze ray with the target.
            transform.position = CoreServices.InputSystem.EyeGazeProvider.HitPosition;
            
            // If no target is hit, show the object at a default distance along the gaze ray.
            //gameObject.transform.position =
            //CoreServices.InputSystem.EyeGazeProvider.GazeOrigin +
            //CoreServices.InputSystem.EyeGazeProvider.GazeDirection.normalized * defaultDistanceInMeters;
        }
    }
}
