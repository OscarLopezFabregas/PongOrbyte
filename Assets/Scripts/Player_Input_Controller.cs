using System.Collections;
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
        //Default speed of the bat to zero on every frame
        leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        if (Input.GetKey (KeyCode.W))
        {
            //Set the velocity to go up 1
            leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, speed, 0f);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            //Set the speed to go down 1
            leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -speed, 0f);

        }

        //Default speed of the bat to zero on every frame
        rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Set the velocity to go up 1
            rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, speed, 0f);

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            //Set the speed to go down 1
            rightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -speed, 0f);

        }

        //Gameplay-Feature Modify Bats Size

        modifyLeftBatSize();
        modifyRightBatSize();

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
