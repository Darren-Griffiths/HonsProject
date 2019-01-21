using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class worksheet : MonoBehaviour {

    public Text paperText;
    bool show;

    // Use this for initialization
    void Start (){
        show = false;
        transform.localPosition = new Vector3(0, 800, 0);
        print(transform.localPosition.y);
        print(show);


        ///Work Sheet text
        SetPaperText();

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.I) && show == false)
        {
            Debug.Log("Pressed I To Show INV");
            transform.localPosition = new Vector3(0, 0, 0);
            show = true;
            print(transform.localPosition.y);
            print(show);
        }
        else if (Input.GetKeyDown(KeyCode.I) && show == true)
        {
            Debug.Log("Pressed I To Show INV");
            transform.localPosition = new Vector3(0, 800, 0);
            show = false;
            print(transform.localPosition.y);
            print(show);
        }

    }

    void SetPaperText()
    {

        paperText.text = PlayerPrefs.GetString("characterName") + ", \n\nHere is a piece of paper, Use it wisely. Time is of thee essence.";
    }
}
