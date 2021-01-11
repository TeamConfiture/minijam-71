using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityStandardAssets.Characters.FirstPerson;

public class LastTrial : MonoBehaviour

    
{
    //[SerializeField] GameObject inputForAnswer;

    [SerializeField] GameObject selectManag;

    [SerializeField] GameObject exit;
    [SerializeField] FirstPersonController player;
    [SerializeField] TMP_Text tmp;
    [SerializeField] public InputField inpF;

    public Text proposition;
    

    string answer = "423";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Loading scene : Final Trial");
       // inputForAnswer.SetActive(false);
        exit.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("enter")){
            SubmitAnswer();
        }
            
    }

    public void HandleClick()
    {
        Debug.Log("Clicked on this red thing");
        LastTrialEnigma();
        
    }

    public void Pause(){
        Time.timeScale =0;
        player.enabled = !player.enabled;
        selectManag.SetActive(false);
        exit.SetActive(true);
    }

    public void Unpause(){
        Time.timeScale =1.0f;
        player.enabled = !player.enabled;
        selectManag.SetActive(true);
        exit.SetActive(false);
    }

    void LastTrialEnigma()
    {

        if (exit.activeSelf == false)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            //inputForAnswer.SetActive(true);
            tmp.SetText("So you've traveled from the first room to this final, third room ? \n1 + 1 = _ _ \nWoah mommy, it's so shiny !");
            inpF.ActivateInputField();
            inpF.Select();
            Pause();
            

        }

        else 
        {

            //inputForAnswer.SetActive(false);
            tmp.SetText("TIME TO PERISH");
            inpF.DeactivateInputField();
            inpF.Select();

        }


        
        // get the player's answer and assign it to answer

        
    }
    public void SubmitAnswer(){
        if (answer.Equals(proposition.text))
        {
            // open door
            Debug.Log("GG WP, you saved the rabbits");
            UnityEngine.SceneManagement.SceneManager.LoadScene("rotatingSpriteScene");
        }

        else
        {
            Debug.Log("Nope");
        }


    }
}
