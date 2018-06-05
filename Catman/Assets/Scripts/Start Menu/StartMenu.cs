using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {

    public GameObject startButton;
    public GameObject optionsButton;
    public GameObject exitButton;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Click");
        Time.timeScale = 1;
        Cursor.visible = true;
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
        Debug.Log("Click");
        SceneManager.LoadScene("Level1");
    }

    /// <summary>
    /// This function will listen for a click on the options button and then hide everything except the background, it will then make all the options page visible without loading a new scene.
    /// This will save some file space, help the cpu out and make the game seem more smoother when navigating through settings.
    /// </summary>

    public void OptionsOnClick()
    {

    }


    //This function will listen for a click on the exit button and then will close application.
    public void ExitOnClick()
    {
        Application.Quit();
    }
}
