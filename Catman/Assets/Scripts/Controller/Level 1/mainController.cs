﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class mainController : MonoBehaviour {

    //public GameObject boltCutter;
    public GameObject inventory;
    public GameObject mouseLook;
    public GameObject outcome;
    int spawnNum = 1;
    public Text chanceText;
    public Text objectiveText;
    public Text lvl2objectiveText;
    public Text losserText;
    public GameObject winText;
    public GameObject lossText;
    public int boltcutter;
    public int hammer;
    public int screwdriver;
    public int hatchet;
    public int saw;
    public int drill;

    public InputField keypadInput;

    //This holds the chance value stored on the player prefs
    public int chances;
    //This holds the character selection value from the player prefs
    public int characterSelection;

    //private mainController mainmenuScript;
    private settings settingsScript;
    public GameObject settings;

    private UnityStandardAssets.Characters.FirstPerson.MouseLook mouselookScript;
    public GameObject MouseLook;





    ////
    //void spawn()
    //{
    //for (int i = 0; i < spawnNum; i++)
    //{
    // Vector3 boltCutterPos = new Vector3(this.transform.position.x + Random.Range(-1.0f, 1.0f),
    //this.transform.position.y + Random.Range(1.0f, 2.0f),
    //this.transform.position.z + Random.Range(-1.0f, 1.0f));
    // Instantiate(boltCutter, boltCutterPos, Quaternion.identity);
    //}
    //}
    ////

    // Use this for initialization
    void Start ()
    {

        Time.timeScale = 1;

        mouselookScript = MouseLook.GetComponent<UnityStandardAssets.Characters.FirstPerson.MouseLook>();
        


        ///Links the character selection in player prefs to a public int to which can be altered via script or editor
        characterSelection = PlayerPrefs.GetInt("characterSelction");
        //chances = PlayerPrefs.GetInt("chances");
        //PlayerPrefs.SetInt("playerChances", 1);
        chances = PlayerPrefs.GetInt("playerChances");

        ///If the character selection is Ashley, the player chances are set to 8
        //if (characterSelection == 1)
        // {
        //    chances = 8;
        // }
        ///If the character selection is Dude, the player chances are set to 6
        // if (characterSelection == 2)
        // {
        //     chances = 6;
        // }
        ///If the character selection is Gavin, the player chances are set to 4
        // if (characterSelection == 3)
        // {
        //     chances = 4;
        // }

        ///Inventory paper text

        ///Stores the players chances in player prefs
        //PlayerPrefs.SetInt("playerChances", chances);

        settingsScript = settings.GetComponent<settings>();
        SetChanceText();
        objectiveText.text = "Objective: Find a way out!";
        boltcutter = 0;
        hammer = 0;
        screwdriver = 0;
        hatchet = 0;
        saw = 0;
        drill = 0;
    }
	
	// Update is called once per frame
	void Update () {

        if (chances < 1)
        {

           chances = 0;
           Time.timeScale = 0;
           mouselookScript.m_cursorIsLocked = false;
            outcome.SetActive(true);
           lossText.SetActive(true);
            losserText.text = PlayerPrefs.GetString("characterName") + ", \n\n\nI gave you chances to leave, but you have decided to stay, for me!\nwell, I do feel privileged. \n\nDon't worry, I'm going to do unimaginable "
           + "things to you. \nHOW EXCITING!";
           
         }
    }


    void SetChanceText ()
    {

        chanceText.text = "Chances: " + chances.ToString();

    }
    public void chanceLost()
    {
        chances = chances - 1;
        SetChanceText();
        ///Stores the players chances in player prefs
        PlayerPrefs.SetInt("playerChances", chances);
        Debug.Log(chances);

    }
    //Loads level 2
    public void nextlvl2OnClick()
    {
        SceneManager.LoadScene("level2");
    }
    //Loads level 3
    public void nextlvl3OnClick()
    {
        SceneManager.LoadScene("level3");
    }
    //Loads level 4
    public void nextlvl4OnClick()
    {
        SceneManager.LoadScene("level4");
    }
    //Loads ending
    public void endingOnClick()
    {
        SceneManager.LoadScene("ending");
    }

    public void ExitOnClick()
    {
        Application.Quit();
    }

    public void MenuOnClick()
    {
        Debug.Log("Click");
        SceneManager.LoadScene("startMenu");
    }
}
