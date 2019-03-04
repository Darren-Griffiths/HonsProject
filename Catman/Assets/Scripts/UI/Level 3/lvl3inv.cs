using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lvl3inv : MonoBehaviour {

    public Text paperText;
    bool show;
    bool ESC;
    private UnityStandardAssets.Characters.FirstPerson.MouseLook mouselookScript;
    public GameObject MouseLook;

    // Use this for initialization
    void Start()
    {
        mouselookScript = MouseLook.GetComponent<UnityStandardAssets.Characters.FirstPerson.MouseLook>();
        show = false;
        ESC = false;
        transform.localPosition = new Vector3(0, 2000, 0);
        print(transform.localPosition.y);
        print(show);


        ///Work Sheet text
        setpapertextwithNoClue();

    }

    // Update is called once per frame
    void Update()
    {
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

        }
        else if (Input.GetKeyDown(KeyCode.Escape) && ESC == true)
        {
            print(ESC);
            ESC = false;
            mouselookScript.m_cursorIsLocked = true;
            Time.timeScale = 1;
        }


    }

    void setpapertextwithNoClue()
    {
        paperText.text = PlayerPrefs.GetString("characterName") + ", \n\nYou should have explored more to see that everything should be set straight.";
    }
}
