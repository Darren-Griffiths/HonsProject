using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class StartMenu : MonoBehaviour {

    public GameObject playButton;
    public GameObject AshleyButton;
    public GameObject DudeButton;
    public GameObject GavinButton;
    public GameObject startButton;
    public GameObject optionsButton;
    public GameObject exitButton;
    public GameObject returnButton;
    public Color red;
    public Color white;
    public GameObject audioMenu;
    public AudioMixer masterMixer;
    public GameObject settings;
    private settings settingsScript;

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1;
        Cursor.visible = true;
        settingsScript = settings.GetComponent<settings>();
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
  

        //if ()
        
        //{
            //ColorBlock ashCB = AshleyButton.GetComponent<Button>().colors;
            //ashCB.normalColor = red;
            //AshleyButton.GetComponent<Button>().colors = ashCB;
        //}
        
        //else
        //{
       //     //shleyButton.GetComponent<Image>().color = white;
            ///     ColorBlock ashCB = AshleyButton.GetComponent<Button>().colors;
            ///     ashCB.normalColor = white;
            ///     AshleyButton.GetComponent<Button>().colors = ashCB;
        //}
 
    }


    //This function will listen for a click on the play button and then load the first gameplay scene.

    public void PlayOnClick()
    {
        //Hides all three buttons
        playButton.SetActive(false);
        optionsButton.SetActive(false);
        exitButton.SetActive(false);

        //Shows These Buttons
        AshleyButton.SetActive(true);
        DudeButton.SetActive(true);
        GavinButton.SetActive(true);
        startButton.SetActive(true);
        returnButton.SetActive(true);
     }

    public void AshleyOnClick()
    {
        settingsScript.characterStart = 1;
        settingsScript.chances = 8;
        Debug.Log(settingsScript.characterStart);
        Debug.Log(settingsScript.chances);
    }

    public void DudeOnClick()
    {
        settingsScript.characterStart = 2;
        settingsScript.chances = 6;
        Debug.Log(settingsScript.characterStart);
        Debug.Log(settingsScript.chances);
    }

    public void GavinOnClick()
    {
        settingsScript.characterStart = 3;
        settingsScript.chances = 4;
        Debug.Log(settingsScript.characterStart);
        Debug.Log(settingsScript.chances);
    }


    public void StartOnClick()
    {
        SceneManager.LoadScene("Level1");     
    }


    /// This function will listen for a click on the options button and then hide everything except the background, it will then make all the options page visible without loading a new scene.
    /// This will save some file space, help the cpu out and make the game seem more smoother when navigating through settings.

    public void OptionsOnClick()
    {

        Debug.Log("Hiding main menu");
        ///Hides all three buttons
        playButton.SetActive(false);
        optionsButton.SetActive(false);
        exitButton.SetActive(false);
        ///Makes these buttons visible
        returnButton.SetActive(true);
        audioMenu.SetActive(true);

    }

    //Returns the main menu starting options
    public void ReturnOnClick()
    {
        //Enables all three buttons below
        playButton.SetActive(true);
        optionsButton.SetActive(true);
        exitButton.SetActive(true);

        //Hides these buttons below
        AshleyButton.SetActive(false);
        DudeButton.SetActive(false);
        GavinButton.SetActive(false);
        startButton.SetActive(false);
        returnButton.SetActive(false);
        audioMenu.SetActive(false);
    }


    //This function will listen for a click on the exit button and then will close application.
    public void ExitOnClick()
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
