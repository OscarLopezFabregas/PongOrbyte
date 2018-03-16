using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;


public class AdManager : MonoBehaviour {

    public static AdManager Instance { set; get; }
    private string appId = "ca-app-pub-4618159390638701~2163200279";
    private BannerView bannerView;

	// Use this for initialization
	private void Start ()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);

               
        SceneManager.LoadScene(1);
        
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
