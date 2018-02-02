using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MyDefaultEventTrackable : DefaultTrackableEventHandler
{

    //public Camera ARCamera;
   // public PlaneFinderBehaviour planeFinderBehaviour;
    public GameObject groundPlaneStage;
    public GameObject PlaneFinder;

   // bool groundPlaneSet = false;

    protected override void OnTrackingFound()
    {
        groundPlaneStage.SetActive(true);
        PlaneFinder.SetActive(true);
        base.OnTrackingFound();
        
        /*if (!groundPlaneSet)
        {
            
            Vector3 screenPos = ARCamera.WorldToScreenPoint(gameObject.transform.position);
            planeFinderBehaviour.GetComponent<PlaneFinderBehaviour>().PerformHitTest(new Vector2(screenPos.x, screenPos.y));
            
            groundPlaneStage.transform.SetPositionAndRotation(gameObject.transform.position, gameObject.transform.rotation);
            groundPlaneSet = true;
        }*/

    }
}