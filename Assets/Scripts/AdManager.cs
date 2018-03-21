using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AdManager : MonoBehaviour
{
    public GameObject ad;

    Intersticial_Controller instance;

    private void Start()
    {
       instance = ad.GetComponent<Intersticial_Controller>();

       instance.ShowIntersticial(); 
    }
}
