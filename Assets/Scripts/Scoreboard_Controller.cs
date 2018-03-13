using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Scoreboard_Controller : MonoBehaviour {

    public Text playerOneScoreText;
    public Text playerTwoScoreText;
    public int playerOneScore;
    public int playerTwoScore;

    public static Scoreboard_Controller instance;

	// Use this for initialization
	void Start ()
    {
        instance = this;
        playerOneScore = playerTwoScore = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

   public void GivePlayerOneAPoint()
    {
        playerOneScore += 1;
        playerOneScoreText.text = playerOneScore.ToString();

    }
   public void GivePlayerTwoAPoint()
    {
        playerTwoScore += 1;
        playerTwoScoreText.text = playerTwoScore.ToString();

    }

}
