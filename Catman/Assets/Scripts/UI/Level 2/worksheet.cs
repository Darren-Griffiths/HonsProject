using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class worksheet : MonoBehaviour {

    public Text paperText;
    bool show;
    bool ESC;

    private UnityStandardAssets.Characters.FirstPerson.MouseLook mouselookScript;
    public GameObject MouseLook;

    public GameObject pauseMenu;
    public GameObject resumeButton;
    public GameObject optionsButton;
    public GameObject backButton;
    public GameObject exitButton;

    public AudioMixer masterMixer;
    public GameObject audioMenu;

    // Use this for initialization
    void Start (){
        mouselookScript = MouseLook.GetComponent<UnityStandardAssets.Characters.FirstPerson.MouseLook>();
        show = false;
        ESC = false;
        transform.localPosition = new Vector3(0, 2000, 0);
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
            mouselookScript.m_cursorIsLocked = false;
        }
        else if (Input.GetKeyDown(KeyCode.I) && show == true)
        {
            Debug.Log("Pressed I To Show INV");
            transform.localPosition = new Vector3(0, 2000, 0);
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
            pauseMenu.SetActive(true);

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
        paperText.text = PlayerPrefs.GetString("characterName") + ", \n\nHere is a piece of paper, Use it wisely. Time is of thee essence." + "\n1. Press ESC to unlock cursor.\n\n2.Click a field to allow entering a number."
            + "\n\n3.After entering a value, press ENTER to save it. \n\n4.Press I to close worksheet.";
    }

    public void keypadEnter()
    {
        mouselookScript.m_cursorIsLocked = true;
        Time.timeScale = 1;
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
