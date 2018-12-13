﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Shows the amount of elasped time since game start
public class Timer : MonoBehaviour {

    Text timeSinceStart;
	// Use this for initialization
	void Start ()
    {
        timeSinceStart = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        UpdateTimer();
	}
    
    void UpdateTimer()
    {
        string minutes = Mathf.Floor(Time.timeSinceLevelLoad / 60).ToString("00");
        string seconds = Mathf.Floor(Time.timeSinceLevelLoad % 60).ToString("00");

        timeSinceStart.text  = string.Format("{0:0}:{1:00}", minutes, seconds);
    }
}
