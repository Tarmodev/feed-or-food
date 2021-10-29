using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class VCamPlayerPosition : MonoBehaviour
{
	// This script sets VCam upward offset to be exactly 0 regardless of follow target position.

    CinemachineVirtualCamera fall_vcam;
	CinemachineTransposer transposer;
	Vector3 offsetPosition;
    void Start()
    {
        fall_vcam = GetComponent<CinemachineVirtualCamera>();
		transposer = fall_vcam.GetCinemachineComponent<CinemachineTransposer>();
    }

    // Update is called once per frame
    void Update()
    {
		offsetPosition = new Vector3(0f, -fall_vcam.m_Follow.position.y+20f, -50f); //magic numbers!
		transposer.m_FollowOffset = offsetPosition;
    }
}
