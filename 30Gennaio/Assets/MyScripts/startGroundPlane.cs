using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class startGroundPlane : MonoBehaviour {
    public GameObject GroundPlane;
    public GameObject PFB;
    
	// Use this for initialization
	void Start () {
       
            GroundPlane.SetActive(true);
            PFB.SetActive(true);
       

	}
	
	// Update is called once per frame
	void Update () {
        
    }
}
