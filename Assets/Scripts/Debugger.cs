using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Debugger : MonoBehaviour
{

    public TextMeshProUGUI uiObject;
    private bool debugger;

    // Start is called before the first frame update
    void Start()
    {
        uiObject.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.D))
        {

            if (uiObject.text != "")
            {
                debugger = false;
                uiObject.text = "";
            }
            else
            {
                print("Ctrl + D");
                debugger = true;
            }
        }

        if (debugger) {
                uiObject.text = SceneManager.GetActiveScene().name + "\n";
                uiObject.text += "Morality: " + Triggers.moralityCheck + "\n";
                uiObject.text += "Forest: " + Triggers.Forest + "\n";
                uiObject.text += "Dessert: " + Triggers.Desert + "\n";
                uiObject.text += "Graveyard: " + Triggers.Graveyard + "\n";
                uiObject.text += "Castle: " + Triggers.Castle + "\n";

            }
    }
}

public static class Triggers
{
    //Forest Triggers
    public static bool Forest = false;
    public static Color corrupted = Color.magenta;
    public static Color cleansed = new Color(1,1,1,0);
    public static bool ramp1 = false;
    public static bool ramp2 = false;
    public static bool ramp3 = false;
    public static bool barn = false;
    public static int moralityCheck = 0;
    public static bool ForestMission = false;


    //Hub Triggers
    public static bool Hub = false;

    //Desert Triggers
    public static bool Desert = false;

    //Graveyard Triggers
    public static bool Graveyard = false;

    //Castle Triggers
    public static bool Castle = false;

}
