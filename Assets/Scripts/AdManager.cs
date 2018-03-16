using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds;
using GoogleMobileAds.Api;


public class AdManager : MonoBehaviour {

    private BannerView bannerView;
    private string appId = "ca-app-pub-4618159390638701~2163200279";
    public string adUnitId = "ca-app-pub-3940256099942544/6300978111";

    // Use this for initialization
    private void Start ()
    {
        
        MobileAds.Initialize(appId);
        this.RequestBanner();

       

    
        
	}
    void RequestBanner()
    {
        // Create a 320x50 banner at the top of the screen.
        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);
        AdRequest request = new AdRequest.Builder().Build();
        bannerView.LoadAd(request);

    }
    public void ShowBanner()
    {

    }

    public void ShowVideo()
    {

    }
	// Update is called once per frame
	void Update ()
    {
		
	}
}
