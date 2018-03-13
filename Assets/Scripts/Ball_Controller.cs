using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour {

    //Get a reference to the rigidbody attached to the gameObject
    public float hitAcceleration = 2f;
    public float ballDeviation = 4f;
    public float startingWait = 1f;
   // public float softBouncesFactor = 1;
    Rigidbody rb;
    
    private float speed = 8;
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
        yield return new WaitForSeconds(startingWait);


        LaunchBall();
    }
    void LaunchBall()
    {
        transform.position = Vector3.zero;
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
            launchDirection.x = -speed;
        }
        if (xDirection == 1)
        {
            launchDirection.x = speed;
        }
        //Check results for y Coin
        if (yDirection == 0)
        {
            launchDirection.y = 0;
        }
        if (yDirection == 1)
        {
            launchDirection.y = -speed / 2;
        }
        if (yDirection == 2)
        {
            launchDirection.y = speed / 2;
        }
        rb.velocity = launchDirection;
    }


    // When we hit something else...
    void OnCollisionEnter(Collision hit)
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

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Goal")
        {
            Debug.Log("Gol!!");
            //TODO: before destroy play GOL animation
            Destroy(gameObject);
        }
    }

}
