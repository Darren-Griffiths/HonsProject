using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Raycast : MonoBehaviour {

    public Text pickupText;

    // Update is called once per frame
    void Update () {

        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.forward,out hit, 100) && hit.collider.gameObject.tag == "Bolt Cutter")
        {
            Debug.Log(hit.transform.name);
            pickupText.enabled = true;
        }
        else
        {
            pickupText.enabled = false;
        }
 
	}
}
