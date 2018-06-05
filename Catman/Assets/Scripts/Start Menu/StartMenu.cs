using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class StartMenu : MonoBehaviour {

    public GameObject startButton;
    public GameObject optionsButton;
    public GameObject exitButton;
    public GameObject returnButton;
    public GameObject audioMenu;
    public int characterStart;

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1;
        Cursor.visible = true;
        characterStart = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }


    //This function will listen for a click on the play button and then load the first gameplay scene.

    public void PlayOnClick()
    {
        SceneManager.LoadScene("Level1");
    }

    /// <summary>
    /// This function will listen for a click on the options button and then hide everything except the background, it will then make all the options page visible without loading a new scene.
    /// This will save some file space, help the cpu out and make the game seem more smoother when navigating through settings.
    /// </summary>

    public void OptionsOnClick()
    {

        Debug.Log("Hiding main menu");
        ///Hides all three buttons
        startButton.SetActive(false);
        optionsButton.SetActive(false);
        exitButton.SetActive(false);
        ///Makes these buttons visible
        returnButton.SetActive(true);
        audioMenu.SetActive(true);

    }

    public void ReturnOnClick()
    {
        ///Enables all three buttons below
        startButton.SetActive(true);
        optionsButton.SetActive(true);
        exitButton.SetActive(true);
        ///Hides these buttons below
        returnButton.SetActive(false);
        audioMenu.SetActive(false);
    }


    //This function will listen for a click on the exit button and then will close application.
    public void ExitOnClick()
    {
        Application.Quit();
    }
}
