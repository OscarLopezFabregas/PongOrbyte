using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using admob;

public class AdManager : MonoBehaviour {

    public static AdManager Instance { set; get; }

    public string BannerID = "ca-app-pub-4618159390638701/8834821345";
    public string VideoID = "ca-app-pub-4618159390638701/2253402444";
	// Use this for initialization
	void Start ()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);

        
        Admob.Instance().initAdmob(BannerID, VideoID);
        Admob.Instance().setTesting(true);
        Admob.Instance().loadInterstitial();

        SceneManager.LoadScene(1);
	}
	
    public void ShowBanner()
    {
        Admob.Instance().showBannerRelative(AdSize.Banner, AdPosition.BOTTOM_CENTER, 5);
    }
    public void ShowVideo()
    {
        if(Admob.Instance().isInterstitialReady())
        {
            Admob.Instance().showInterstitial();
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
