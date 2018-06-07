using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainController : MonoBehaviour {

    public GameObject boltCutter;
    public GameObject inventory;
    public GameObject mouseLook;
    public GameObject outcome;
    int spawnNum = 1;
    public Text chanceText;
    public Text objectiveText;
    public GameObject winText;
    public GameObject lossText;
    public int boltcutter;
    public int hammer;
    public int screwdriver;
    public int hatchet;
    public int saw;
    public int drill;

    private mainController mainmenuScript;
    private settings settingsScript;
    public GameObject settings;




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
        settingsScript = settings.GetComponent<settings>();
        //playerCam = mouselook.GetComponent<mainController>();
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

        

        if (settingsScript.chances < 1)
        {

            settingsScript.chances = 0;
            Time.timeScale = 0;
            outcome.SetActive(true);
            lossText.SetActive(true);

        }
	}


    void SetChanceText ()
    {

        chanceText.text = "Chances: " + settingsScript.chances.ToString();

    }
    public void chanceLost()
    {
        settingsScript.chances = settingsScript.chances - 1;
        SetChanceText();
        Debug.Log(settingsScript.chances);
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
