﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input_Controller : MonoBehaviour
{
    //Script that handles input from two players
    //Player 1 -> Controls left bat with W/S
    //Player -> Controls with Arrows

    public GameObject leftBat;
    public GameObject rightBat;
    public float speed = 8f;
    public float leftBatSize = 3.4f;
    public float rightBatSize = 3.4f;

   

	// Use this for initialization
	void Start ()
    {
      
	}
	
	// Update is called once per frame
	void Update ()
    {
        float nRightBatPos = rightBat.transform.position.y / 5.9f;
        float nLeftBatPos = leftBat.transform.position.y / 5.9f;

        //Default speed of the bat to zero on every frame
        leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        //if (Input.GetKey (KeyCode.W))
        //{
        //    //Set the velocity to go up 1
        //    leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, speed, 0f);

        //}
        //else if (Input.GetKey(KeyCode.S))
        //{
        //    //Set the speed to go down 1
        //    leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -speed, 0f);

        //}
        //Default speed of the bat to zero on every frame
        rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    //Set the velocity to go up 1
        //    rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, speed, 0f);

        //}
        //else if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    //Set the speed to go down 1
        //    rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -speed, 0f);

        //}
        foreach (Touch touch in Input.touches)
        {
            float nTouchPosition = (touch.position.y - (1080/2)) / (1080 / 2);
            
            if(touch.position.x > 1920/2)
            {
                float distance = nTouchPosition - nRightBatPos;
            
                if (distance > 0.05)
                    rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, speed, 0f);
                else if (distance < -0.05)
                    rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -speed, 0f);
                      
            }


            if (touch.position.x < 1920/2)
            {
                float distance = nTouchPosition - nLeftBatPos;
                if (distance > 0.05)
                    leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, speed, 0f);
                else if (distance < -0.05)
                    leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -speed, 0f);
            }



        }



     

    }

    void modifyLeftBatSize ()
    {
        leftBat.GetComponent<Transform>().localScale = new Vector3(0.4f, leftBatSize, 1f);
    }
    void modifyRightBatSize()
    {
        rightBat.GetComponent<Transform>().localScale = new Vector3(0.4f, rightBatSize, 1f);
    }
}
