using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using System;

public class DeployStanceOnce : MonoBehaviour {
    public GameObject StageAncora;
    private PositionalDeviceTracker TrackerDispositivo;
    private GameObject AncoraPrevista;

	// Use this for initialization
	void Start () {
        if (StageAncora == null)
            return;
        StageAncora.SetActive(false);

		
	}

    public void Awake()
    {
        VuforiaARController.Instance.RegisterVuforiaStartedCallback(OnVuforiaStarted);
    }

    public void OnDestroy()
    {
        VuforiaARController.Instance.UnregisterVuforiaStartedCallback(OnVuforiaStarted);
    }


    public void OnVuforiaStarted()
    {
        TrackerDispositivo = TrackerManager.Instance.GetTracker<PositionalDeviceTracker>();
    }

    public void OnInteractiveHitTest(HitTestResult result)
    {
        if (result == null || StageAncora == null) return;

        var ancora = TrackerDispositivo.CreatePlaneAnchor(Guid.NewGuid().ToString(),result);
        if (ancora != null)
        {
            StageAncora.transform.parent = ancora.transform;
            StageAncora.transform.localPosition = Vector3.zero;
            StageAncora.transform.localRotation = Quaternion.identity;
            StageAncora.SetActive(true);
        }
        if (AncoraPrevista != null)
            Destroy(AncoraPrevista);
        AncoraPrevista = ancora;
    }

    

    // Update is called once per frame
    void Update () {
		
	}
}
