using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LastTrial : MonoBehaviour

    
{
    [SerializeField] GameObject inputForAnswer;
    [SerializeField] private TMP_Text tmp;
    [SerializeField] private InputField inpF;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Loading scene : Final Trial");
        inputForAnswer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Current Scene : Final Trial");
    }

    public void HandleClick()
    {
        Debug.Log("Clicked on this red thing");
        LastTrialEnigma();
        
    }

    void LastTrialEnigma()
    {

        if (inputForAnswer.activeSelf == false)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            inputForAnswer.SetActive(true);
            tmp.SetText("So you've traveled from the first room to this final, third room ? \n1 + 1 = _ _ \nWoah mommy, it's so shiny !");
            inpF.ActivateInputField();
            inpF.Select();

        }

        else 
        {

            inputForAnswer.SetActive(false);
            tmp.SetText("TIME TO PERISH");
            inpF.DeactivateInputField();
            inpF.Select();

        }

        string answer = "";
        
        // get the player's answer and assign it to answer

        if (answer == "423")
        {
            // open door
            Debug.Log("GG WP, you saved the rabbits");
        }

        else
        {
            Debug.Log("GG WP, you saved the rabbits");
        }


    }
}
