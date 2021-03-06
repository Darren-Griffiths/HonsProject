﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class lvl4inv : MonoBehaviour {

    bool show;
    bool ESC;
    public Vector3 inventoryPosition;
    public Text paperText;

    private UnityStandardAssets.Characters.FirstPerson.MouseLook mouselookScript;
    public GameObject MouseLook;

    public GameObject pauseMenu;
    public GameObject resumeButton;
    public GameObject optionsButton;
    public GameObject backButton;
    public GameObject exitButton;

    public AudioMixer masterMixer;
    public GameObject audioMenu;

    private pickup pickupScript;
    private mainController maincontrollerScript;
    public GameObject controller;


    // Use this for initialization
    void Start()
    {
        maincontrollerScript = controller.GetComponent<mainController>();
        mouselookScript = MouseLook.GetComponent<UnityStandardAssets.Characters.FirstPerson.MouseLook>();
        ESC = false;
        maincontrollerScript.objectiveText.text = "Objective: If you can find the way out then you can leave.";
        //print(transform.localPosition.y);
        //print(show);

        ///Inventory paper text
        //SetPaperText();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.I) && show == false)
        {
            //Debug.Log("Pressed I To Show INV This script is active");
            transform.localPosition = new Vector3(0, 0, 0);
            show = true;
            print(transform.localPosition.y);
            print(show);
            mouselookScript.m_cursorIsLocked = false;
        }

        else if (Input.GetKeyDown(KeyCode.I) && show == true)
        {
            //Debug.Log("Pressed I To Show INV");
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
            print(ESC);
            mouselookScript.m_cursorIsLocked = false;
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
            print("got here");

        }
        else if (Input.GetKeyDown(KeyCode.Escape) && ESC == true)
        {
            print(ESC);
            ESC = false;
            mouselookScript.m_cursorIsLocked = true;
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
        }
    }

    void SetPaperText()
    {

        //paperText.text = PlayerPrefs.GetString("characterName") + ",\n\nI have been watching you. \nfor so long I have been wanting you. \nNow that I have you.\nI feel so guilty for taken you." +
        //"\nIt pains me to think you don't want me.\n\nSo heres the deal, \n\nI will give you NINE chances to show me that you want me too...\nminus the one chance I have just giving you.";
    }


    public void resumeClick()
    {
        print(ESC);
        ESC = false;
        mouselookScript.m_cursorIsLocked = true;
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }

    public void optionsClick()
    {
        //Hide these buttons
        resumeButton.SetActive(false);
        optionsButton.SetActive(false);
        exitButton.SetActive(false);
        //Show these buttons
        audioMenu.SetActive(true);
        backButton.SetActive(true);
    }

    public void backClick()
    {
        //Show these buttons
        resumeButton.SetActive(true);
        optionsButton.SetActive(true);
        exitButton.SetActive(true);
        //Hide these buttons
        audioMenu.SetActive(false);
        backButton.SetActive(false);
    }
    public void exitClick()
    {
        Application.Quit();
    }

    //Slider controls the music volume
    public void SetMusicLvl(float musicLvl)
    {
        masterMixer.SetFloat("musicVol", musicLvl);
    }

    //Slider controls the sfx volume
    public void SetSoundFXLvl(float sfxLvl)
    {
        masterMixer.SetFloat("sfxVol", sfxLvl);
    }
}