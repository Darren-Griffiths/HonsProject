using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evilcontainer : MonoBehaviour {

    public float speed = 1;

	// Use this for initialization
	void Start ()
    {

      


    }
	
	// Update is called once per frame
	void Update () {


        if (this.gameObject.transform.position.z >= -24.50)
        {
            this.gameObject.transform.position += Vector3.back * speed * Time.deltaTime;
        }
		
	}
}
