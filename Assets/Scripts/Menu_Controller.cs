﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class Menu_Controller : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
      //  AdManager.Instance.ShowBanner();

		
	}

    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }
    
    
    //only works in .exe
    public void QuitGame()
    {
        Application.Quit();
    }
}
