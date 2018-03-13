using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour {

    //Get a reference to the rigidbody attached to the gameObject
    public float hitAcceleration = 2f;
    public float ballDeviation = 4f;
    public float startingWait = 1f;
    public float launchSpeed = 8;

    // public float softBouncesFactor = 1;
    Rigidbody rb;
    
	// Use this for initialization
	void Start ()
    {
        //Get shortcut to rigidbody component
        rb = GetComponent<Rigidbody>();
        StartCoroutine(Pause());
       
     
	}
	
	// Update is called once per frame
	void Update ()
    {
	}
    IEnumerator Pause()
    {
        //Reset Values
        transform.position = Vector3.zero;
        rb.velocity = Vector3.zero;

        yield return new WaitForSeconds(startingWait);
        LaunchBall();
    }
    void LaunchBall()
    {
        //Ball Chooses a direction
        //Ball Flies that direction
        //Flip a coin, determine direction in x-axis
        int xDirection = Random.Range(0, 2);

        //Flip a coin, determine direction in y-axis
        int yDirection = Random.Range(0, 3);

        Vector3 launchDirection = new Vector3();
        //Check results for x Coin
        if (xDirection == 0)
        {
            launchDirection.x = -launchSpeed;
        }
        if (xDirection == 1)
        {
            launchDirection.x = launchSpeed;
        }
        //Check results for y Coin
        if (yDirection == 0)
        {
            launchDirection.y = 0;
        }
        if (yDirection == 1)
        {
            launchDirection.y = -launchSpeed / 2;
        }
        if (yDirection == 2)
        {
            launchDirection.y = launchSpeed / 2;
        }
        // rb.velocity.Set(launchDirection.x, launchDirection.y, 0);
        rb.velocity = launchDirection;
    }

    // When we hit something else...
    void OnCollisionExit(Collision hit)
    {
        float ballBatDistance = (transform.position.y 
            - hit.gameObject.transform.position.y) * ballDeviation;
        //If it was the top or bottom of the screen...
        //1st option to increase the speed while playing
        if (hit.gameObject.tag == "Boundaries" && rb.velocity.x > 0) 
        {
            rb.velocity = new Vector3(rb.velocity.x + hitAcceleration, rb.velocity.y);
                
        }

        if (hit.gameObject.tag == "Boundaries" && rb.velocity.x < 0) 
        {
            
            rb.velocity = new Vector3(rb.velocity.x - hitAcceleration, rb.velocity.y);

        }
        //If it was one of the bats
        if (hit.gameObject.tag == "Bat" && rb.velocity.x > 0)
        {
            rb.velocity = new Vector3(rb.velocity.x + hitAcceleration, rb.velocity.y + ballBatDistance);

        }
        if (hit.gameObject.tag == "Bat" && rb.velocity.x < 0)
        {
            rb.velocity = new Vector3(rb.velocity.x - hitAcceleration, rb.velocity.y + ballBatDistance);
        }

        //TODO: "Soften the bounces" Idea, to refine collision with boundaries, to make the game easier. 
        //    if (hit.gameObject.name == "TopBoundaries")
        // rb.velocity = new Vector3(rb.velocity.x - hitAcceleration, rb.velocity.y - softBouncesFactor);
        //etc...

    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "Right_Goal")
        {
         
            //TODO: before destroy play GOL animation
            Scoreboard_Controller.instance.GivePlayerTwoAPoint();
            StartCoroutine(Pause());
            
        }

        if (other.gameObject.name == "Left_Goal")
        {

            //TODO: before destroy play GOL animation
            Scoreboard_Controller.instance.GivePlayerOneAPoint();
            StartCoroutine(Pause());

        }
    }

}
