﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

    bool show;
    bool ESC;
    public Vector3 inventoryPosition;
    public Text paperText;

    private StartMenu startmenuScript;
    public GameObject StartMenu;

    private UnityStandardAssets.Characters.FirstPerson.MouseLook mouselookScript;
    public GameObject MouseLook;

    // Use this for initialization
    void Start ()
    {
        startmenuScript = StartMenu.GetComponent<StartMenu>();
        mouselookScript = MouseLook.GetComponent<UnityStandardAssets.Characters.FirstPerson.MouseLook>();
        show = false;
        ESC = false;
        transform.localPosition = new Vector3(0, 9000, 0);
        print(transform.localPosition.y);
        print(show);


        ///Inventory paper text
        SetPaperText();
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.I) && show == false)
        {
            Debug.Log("Pressed I To Show INV This script is active");
            transform.localPosition = new Vector3(0, 0, 0);
            show = true;
            print(transform.localPosition.y);
            print(show);
            mouselookScript.m_cursorIsLocked = false;
        }

        else if (Input.GetKeyDown(KeyCode.I) && show == true)
        {
            Debug.Log("Pressed I To Show INV");
            transform.localPosition = new Vector3(0, 9000, 0);
            show = false;
            print(transform.localPosition.y);
            print(show);
            mouselookScript.m_cursorIsLocked = true;
        }
        if (Input.GetKeyDown(KeyCode.Escape) && ESC == false)
        {
            print(ESC);
            ESC = true;
            mouselookScript.m_cursorIsLocked = false;
            Time.timeScale = 0;

        }
        else if (Input.GetKeyDown(KeyCode.Escape) && ESC == true)
        {
            print(ESC);
            ESC = false;
            mouselookScript.m_cursorIsLocked = true;
            Time.timeScale = 1;
        }
    }

    void SetPaperText()
    {

        paperText.text = PlayerPrefs.GetString("characterName") + ", \n\nI have been watching you, for so long I have been wanting you.Now I have you, II feel so guilty for taken you." +
        "It pains me to think you don't want me. So heres the deal" + PlayerPrefs.GetString("characterName") + ", I will give you NINE chances to show me you want me...except from the once chance I have just giving you to show me you truely dont care.";
    }
}
