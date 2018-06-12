using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class settings : MonoBehaviour {


    public AudioMixer masterMixer;
    public int chances;
    public int characterSelection;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Use this for initialization
    void Start ()
    {

      


		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
