﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DestroyCanvas : MonoBehaviour
{
    public Button startButton;
    public GameObject canvas;
    public GameObject canvas2;
    public GameObject canvas3;

    
    

    // Start is called before the first frame update
    void Start()
    {
        canvas3.SetActive(false);
        canvas2.SetActive(false);
		startButton.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

     void TaskOnClick()
    {
        GameObject.Find("CameraFollow").GetComponent<CameraFollowing>().start = true;

        canvas.SetActive(false);
        canvas2.SetActive(true);
        

    }
}
