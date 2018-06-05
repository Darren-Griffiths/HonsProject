using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour {

    void R(Collision other)
    {
        if (other.gameObject.name == "Raycast" )
        {
            Debug.Log("am touching the object");
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("im detecting player");
                this.GetComponent<BoxCollider>().enabled = false;
                this.GetComponent<MeshRenderer>().enabled = false;
                Invoke("Respawn", 5);
            }
        }
    }

    void Respawn()
    {
        this.transform.localPosition = new Vector3(0,1,0);
        this.GetComponent<BoxCollider>().enabled = true;
        this.GetComponent<MeshRenderer>().enabled = true;
    }

    // Use this for initialization
    void Start () {


    }
	
	// Update is called once per frame
	void Update ()
    {

    }
}
