using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class objtrigger : MonoBehaviour {

    public Text objectiveText;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            pickup pickupScript = col.gameObject.GetComponent<pickup>();
            Debug.Log("detecting");
            //if (pickupScript.boltcuttersObj != null)
            {
                objectiveText.text = "Objective: Got some boltcutters, I wonder if these could get through those chains.";
            }
            //if (pickupScript.boltcuttersObj == null)
            {
                objectiveText.text = "Objective: Find a tool to remove the chain";
            }
        }
    }
}
