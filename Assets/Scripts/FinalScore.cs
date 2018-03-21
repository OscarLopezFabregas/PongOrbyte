using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text PlayerOneFinalScore;
    public Text PlayerTwoFinalScore;

    // Use this for initialization
    void Start()
    {
        Scoreboard_Controller.instance.playerOneScoreText = PlayerOneFinalScore;
        Scoreboard_Controller.instance.playerTwoScoreText = PlayerTwoFinalScore;

    }


}