using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;

public class Intersticial_Controller : MonoBehaviour
{
    public string AddId;
    public bool show;
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this);
        EasyGoogleMobileAds.GetInterstitialManager()
            .PrepareInterstitial(AddId);

       
    }
    private void Update()
    {
        Scene CurrentScene = SceneManager.GetActiveScene();
        if (CurrentScene.name == "PlayerOneVictory")
        {
            ShowIntersticial();
            show = false;
        }

        if (CurrentScene.name == "PlayerTwoVictory")
        {
            ShowIntersticial();
            show = false;
        }
    }


    public void ShowIntersticial()
    {
        if(show)
        {
            EasyGoogleMobileAds.GetInterstitialManager().ShowInterstitial();
        }
    }
}
