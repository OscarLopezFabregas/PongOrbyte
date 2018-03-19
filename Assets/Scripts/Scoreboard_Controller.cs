using System.Collections;
using System.Collections.Generic;


using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Scoreboard_Controller : MonoBehaviour {

    public Text playerOneScoreText;
    public Text playerTwoScoreText;
    public Text roundText;
    public int playerOneScore;
    public int playerTwoScore;
    int round;
    public int victoryCondition = 5;

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
        round += 1;
        roundText.text = round.ToString();

        if(playerOneScore>= victoryCondition)
        {
           SceneManager.LoadScene(2);
        }
    }
   public void GivePlayerTwoAPoint()
    {
        playerTwoScore += 1;
        playerTwoScoreText.text = playerTwoScore.ToString();
        round += 1;
        roundText.text = round.ToString();
        if (playerTwoScore >= victoryCondition)
        {
            SceneManager.LoadScene(3);
        }

    }

}
