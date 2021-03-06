﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPerspectiveController : MonoBehaviour
{
    public Camera FPCamera;
    public Camera OTSCamera;

    private bool OTSMode;

	// Use this for initialization
	void Start()
    {
        FPCamera.enabled = false;
        OTSCamera.enabled = true;
        OTSMode = true;
        OTSCamera.gameObject.tag = "MainCamera";
        FPCamera.gameObject.tag = "Untagged";
	}

    void OnDisable()
    {
        FPCamera.enabled = false;
        OTSCamera.enabled = false;
    }

    // Update is called once per frame
    void Update ()
    {
		if (Input.GetKeyDown(KeyCode.V))
        {
            OTSMode = !OTSMode;
            FPCamera.enabled = !OTSMode;
            OTSCamera.enabled = OTSMode;
            OTSCamera.gameObject.tag = OTSMode ? "MainCamera" : "Untagged";
            FPCamera.gameObject.tag = OTSMode ? "Untagged" : "MainCamera";
        }
	}

    
}
