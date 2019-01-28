using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup : MonoBehaviour {

    //Level1 Declare
    public GameObject inventoryPanel;
    public GameObject[] inventoryIcons;
    public GameObject controller;
    public GameObject winText;
    public GameObject outcome;
    public Text pressText;
    public Text pickupText;
    public Text tryText;
    public Text bc0Text;
    public Text bc1Text;
    public Text ham0Text;
    public Text ham1Text;
    public Text sd0Text;
    public Text sd1Text;
    public Text hatch0Text;
    public Text hatch1Text;
    public Text saw0Text;
    public Text saw1Text;
    public Text drill0Text;
    public Text drill1Text;
    public Text objectiveText;
    public Text winnerText;
    public int doorDistance = 50;
    public int objDistance = 2;
    public int objdoorDistance = 2;

    //Level 2 Declare
    RaycastHit keypadHit;
    public float keypadDistance = 1;
    public GameObject keypadInput;
    public Text keypadpressText;
    RaycastHit door2;
    public GameObject mouselookObj;
    private UnityStandardAssets.Characters.FirstPerson.MouseLook mouselookScript;

    //Level 3 Declare
    public GameObject cat1;
    public GameObject cat2;
    public GameObject cat3;
    public GameObject cat4;
    public int objstatueDistance = 1;
    public float statueRotate = 900;
    RaycastHit door3;
    RaycastHit hit;
    RaycastHit statueHit;
    RaycastHit door;
    RaycastHit objDoor;
    public AudioSource negTry;
    public AudioSource posTry;
    public AudioSource collectObj;
    public AudioSource nomoreTry;
    bool statueCorrect;
    public float cat1Rot;


    private mainController maincontrollerScript;
    private settings settingsScript;
    public GameObject settings;

    void Start()
    {
        maincontrollerScript = controller.GetComponent<mainController>();
        settingsScript = settings.GetComponent<settings>();
        mouselookScript = mouselookObj.GetComponent<UnityStandardAssets.Characters.FirstPerson.MouseLook>();
        cat1Rot = cat1.transform.rotation.z;

    }

    void Update()
    {
       ///Level 1
       ///Update 
       ///

        //Raycast for Door
        if (Physics.Raycast(transform.position, transform.forward, out door, doorDistance) && door.collider.gameObject.tag == "Door")
        {
            Debug.Log("door");
            tryText.enabled = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (bc1Text.enabled == true)
                {
                    posTry.Play();
                    Time.timeScale = 0;
                    outcome.SetActive(true);
                    winText.SetActive(true);
                    winnerText.text = PlayerPrefs.GetString("characterName")+",\n You have successively passed the first challege with (" + maincontrollerScript.chances.ToString() + ") chances. Why don't you wanna stay...with me?\n\n\n\n\n\n\n"+
                    "We are done here press ESC....";
                    mouselookScript.m_cursorIsLocked = false;
                }
                else if (maincontrollerScript.chances > 0)
                {
                    negTry.Play();
                    maincontrollerScript.chanceLost();
                }
            }
        }
        else
        {
            tryText.enabled = false;
        }

        if (maincontrollerScript.chances == 0)
        {
           nomoreTry.Play();
        }

        //Raycast for Objective Door
        if (Physics.Raycast(transform.position, transform.forward, out objDoor, objdoorDistance) && objDoor.collider.gameObject.tag == "Door")
        {
   
            {
             objectiveText.text = "Objective: Well Done, you have found the door. Find tools to try the lock";
            }
        }

        

        //Raycast for Boltcutter
        if (Physics.Raycast(transform.position, transform.forward, out hit, 2) && hit.collider.gameObject.tag == "Key Object")
        {
            //Debug.Log(hit.transform.name);
            pickupText.enabled = true;

            //Boltcutter
            if (hit.collider.gameObject.name == "boltcutters" && Input.GetKeyDown(KeyCode.E))
            {
                collectObj.Play();
                Debug.Log("Being Pressed");
                Destroy(hit.transform.gameObject);
                Debug.Log("Destroyed");
                maincontrollerScript.boltcutter = 1;
                Debug.Log("Added 1");
                bc0Text.enabled = false;
                Debug.Log("Turned off 0");
                bc1Text.enabled = true;
                Debug.Log("Turned on 1");
                

            }
            //Hatchet
            if (hit.collider.gameObject.name == "hatchet" && Input.GetKeyDown(KeyCode.E))
            {
                collectObj.Play();
                Debug.Log("Being Pressed");
                Destroy(hit.transform.gameObject);
                Debug.Log("Destroyed");
                maincontrollerScript.hatchet = 1;
                Debug.Log("Added 1");
                hatch0Text.enabled = false;
                Debug.Log("Turned off 0");
                hatch1Text.enabled = true;
                Debug.Log("Turned on 1");
            }
            //Saw
            if (hit.collider.gameObject.name == "saw" && Input.GetKeyDown(KeyCode.E))
            {
                collectObj.Play();
                Debug.Log("Being Pressed");
                Destroy(hit.transform.gameObject);
                Debug.Log("Destroyed");
                maincontrollerScript.saw = 1;
                Debug.Log("Added 1");
                saw0Text.enabled = false;
                Debug.Log("Turned off 0");
                saw1Text.enabled = true;
                Debug.Log("Turned on 1");
            }
            //Hammer
            if (hit.collider.gameObject.name == "hammer" && Input.GetKeyDown(KeyCode.E))
            {
                collectObj.Play();
                Debug.Log("Being Pressed");
                Destroy(hit.transform.gameObject);
                Debug.Log("Destroyed");
                maincontrollerScript.hammer = 1;
                Debug.Log("Added 1");
                ham0Text.enabled = false;
                Debug.Log("Turned off 0");
                ham1Text.enabled = true;
                Debug.Log("Turned on 1");
            }
            //Screwdriver
            if (hit.collider.gameObject.name == "screwdriver" && Input.GetKeyDown(KeyCode.E))
            {
                collectObj.Play();
                Debug.Log("Being Pressed");
                Destroy(hit.transform.gameObject);
                Debug.Log("Destroyed");
                maincontrollerScript.screwdriver = 1;
                Debug.Log("Added 1");
                sd0Text.enabled = false;
                Debug.Log("Turned off 0");
                sd1Text.enabled = true;
                Debug.Log("Turned on 1");
            }
            //Drill
            if (hit.collider.gameObject.name == "drill" && Input.GetKeyDown(KeyCode.E))
            {
                collectObj.Play();
                Debug.Log("Being Pressed");
                Destroy(hit.transform.gameObject);
                Debug.Log("Destroyed");
                maincontrollerScript.drill = 1;
                Debug.Log("Added 1");
                drill0Text.enabled = false;
                Debug.Log("Turned off 0");
                drill1Text.enabled = true;
                Debug.Log("Turned on 1");
            }
            //Door
        }
        else
        {
            pickupText.enabled = false;
        }


        ///Level 2
        ///Update
        //Raycast for Keypad
        if (Physics.Raycast(transform.position, transform.forward, out keypadHit, keypadDistance) && keypadHit.collider.gameObject.tag == "Keypad")
        {
            Debug.Log("can see keypad");
            keypadpressText.enabled = true;
            //Keypad
            if (Input.GetKeyDown(KeyCode.E) && hit.collider.gameObject.name == "Keypad")
            {
             Debug.Log("Keypad is being pressed");
             mouselookScript.m_cursorIsLocked = false;
             //GameObject.Find("Player").GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
                keypadpressText.text = ("Click To Input Your Answer & Press Enter To Save It");
                keypadInput.SetActive(true);
            }
        }
        else
        {
            keypadpressText.text = ("Press E To Use Keypad");
            keypadInput.SetActive(false);
            keypadpressText.enabled = false;
        }

        //Raycast for Door
        if (Physics.Raycast(transform.position, transform.forward, out door2, doorDistance) && door.collider.gameObject.tag == "Door2")
        {
            Debug.Log("door");
            tryText.text = "Press E To Open Door";
            tryText.enabled = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (maincontrollerScript.keypadInput.text == "554")
                {
                    Time.timeScale = 0;
                    winnerText.text = PlayerPrefs.GetString("characterName") + ",\n\n\nYou have successively passed the second challenge with (" + maincontrollerScript.chances.ToString() + ")" +
                    " chances. \n\n\n\nWhy don't you wanna STAY WITH ME!?" + "\n\nWe are done here press ESC....";
                    posTry.Play();
                    outcome.SetActive(true);
                    winText.SetActive(true);
                }
                else if (maincontrollerScript.keypadInput.text != "554")
                {
                    negTry.Play();
                    maincontrollerScript.chanceLost();
                }
            }
        }
        else
        {
            tryText.enabled = false;
        }

        //Raycast for Objecive
        if (Physics.Raycast(transform.position, transform.forward, out hit, 2) && hit.collider.gameObject.tag == "Equation")
        {
            //Debug.Log(hit.transform.name);
            maincontrollerScript.objectiveText.text = "Objective: Solve the equation. \n Press Iv For A Work Sheet";
        }

        ///Level 3
            ///Update Void
            ///
            ///
            //Raycast for Statues
            if (Physics.Raycast(transform.position, transform.forward, out statueHit, objstatueDistance) && statueHit.collider.gameObject.tag == "Statue")
        {
            //Debug.Log("See a cat");
            pressText.enabled = true;

            //Statue 1
            if (Input.GetKeyDown(KeyCode.E) && hit.collider.gameObject.name == "Cat1" || Input.GetKeyDown(KeyCode.E) && hit.collider.gameObject.name == "Stand1")
            {
                
                Debug.Log("Being Pressed Against A Cat");
                cat1.transform.Rotate(0, 0, 90);
                print(cat1.transform.rotation.z);
                cat1Rot = cat1.transform.rotation.z;
                print(cat1Rot);
                //cat1.transform.Rotate(Vector3.right * Time.deltaTime);



            }

            //Statue 2
            if (Input.GetKeyDown(KeyCode.E) && hit.collider.gameObject.name == "Cat2" || Input.GetKeyDown(KeyCode.E) && hit.collider.gameObject.name == "Stand2")
            {

                Debug.Log("Being Pressed Against A Cat");
                cat2.transform.Rotate(0, 0, statueRotate);
            }

            //Statue 3
            if (Input.GetKeyDown(KeyCode.E) && hit.collider.gameObject.name == "Cat3" || Input.GetKeyDown(KeyCode.E) && hit.collider.gameObject.name == "Stand3")
            {

                Debug.Log("Being Pressed Against A Cat");
                cat3.transform.Rotate(0, 0, statueRotate);
            }

            //Statue 4
            if (Input.GetKeyDown(KeyCode.E) && hit.collider.gameObject.name == "Cat4" || Input.GetKeyDown(KeyCode.E) && hit.collider.gameObject.name == "Stand4")
            {

                Debug.Log("Being Pressed Against A Cat");
                cat4.transform.Rotate(0, 0, statueRotate);
            }

        }
        else
        {
            pressText.enabled = false;
        }

        if (Physics.Raycast(transform.position, transform.forward, out door3, doorDistance) && door.collider.gameObject.tag == "Door3")
        {
            //Debug.Log("door");
            tryText.text = "Press E To Open Door";
            tryText.enabled = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (cat1Rot <= 0) 
                {
                    print(cat1.transform.rotation.z);
                    print(cat1Rot);
                    Time.timeScale = 0;
                    winnerText.text = PlayerPrefs.GetString("characterName") + ",\n\n\nYou have successively passed the third challenge with (" + maincontrollerScript.chances.ToString() + ")" +
                    " chances. \n\n\n\nWhy don't you wanna STAY WITH ME!?" + "\n\nWe are done here press ESC....";
                    posTry.Play();
                    outcome.SetActive(true);
                    winText.SetActive(true);
                }

               else if (maincontrollerScript.chances > 0)
               {
                   negTry.Play();
                   maincontrollerScript.chanceLost();
                   print(cat1.transform.rotation.z);
               }
            }         
        }

        //if (cat1.transform.eulerAngles.y == -270)
        //{

        //v}

    }
}
