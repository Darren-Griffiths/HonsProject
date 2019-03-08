using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evilcontainer : MonoBehaviour {

    public float speed = 1;
    public bool moving;
    public bool introPlaying;
    public AudioSource engine;
    public AudioSource enginedown;
    public AudioSource metalIntro;
    public AudioSource metalLoop;
    public AudioSource metalOutro;
    public AudioClip outro;

    // Use this for initialization
    void Start ()
    {
        Invoke("metalStart", 0.5f);
        Invoke("metalloopStart", 3);
    }
	
	// Update is called once per frame
	void Update () {
  
        if (this.gameObject.transform.position.z >= -24.50)
        {
            this.gameObject.transform.position += Vector3.back * speed * Time.deltaTime;
            moving = true;
        }
        else
        {
            moving = false;
        }
        if (moving == false)
        {
            engine.Stop();
            metalLoop.Stop();
        }
	}

    void metalStart()
    {
        metalIntro.Play();
    }

    void metalloopStart()
    {
        metalLoop.Play();
    }
    void metaloutroStart()
    {
        metalOutro.Play();
    }

}
