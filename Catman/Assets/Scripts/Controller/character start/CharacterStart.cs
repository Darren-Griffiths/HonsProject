using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStart : MonoBehaviour {

    //This holds the chance value stored on the player prefs
    public int chances;
    //This holds the character selection value from the player prefs
    public int characterSelection = 1;

    //private mainController mainmenuScript;
    private settings settingsScript;
    public GameObject settings;

    // Use this for initialization
    void Start ()
    {        
        ///Links the character selection in player prefs to a public int to which can be altered via script or editor
        characterSelection = PlayerPrefs.GetInt("characterSelction");

        ///If the character selection is Ashley, the player chances are set to 8
        if (characterSelection == 1)
        {
            chances = 8;
        }
        ///If the character selection is Dude, the player chances are set to 6
        if (characterSelection == 2)
        {
            chances = 6;
        }
        ///If the character selection is Gavin, the player chances are set to 4
        if (characterSelection == 3)
        {
            chances = 4;
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
