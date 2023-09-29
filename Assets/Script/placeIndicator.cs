using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.CompilerServices;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class placeIndicator : MonoBehaviour
{
    private ARRaycastManager raycastManager;
    private GameObject indicator;
    private List<ARRaycastHit> hit = new List<ARRaycastHit>();
    // Start is called before the first frame update
    void Start()
    {
        raycastManager = FindAnyObjectByType<ARRaycastManager>();
        indicator = transform.GetChild(0).gameObject;
        indicator.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        var ray = new Vector2(Screen.width / 2, Screen.height / 2);
        if (raycastManager.Raycast(ray, hit, TrackableType.Planes))
        {
            Pose hitPose = hit[0].pose;

            transform.position = hitPose.position;
            transform.rotation = hitPose.rotation;

            if (!indicator.activeInHierarchy)
            {
                indicator.SetActive(true);
            }
        }
    }
}
