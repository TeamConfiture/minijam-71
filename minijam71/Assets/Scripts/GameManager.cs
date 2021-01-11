using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

///<summary>This object is singleton. It is Suposed to make sure that every data are correctly transmitted between all scenes
///and that the representations are correctly handled according to player progression</summary>
public class GameManager : MonoBehaviour
{
    #region atributes
    private static GameManager instance;
    
    ///Contain all nodes of story to keep track of player progression
    [SerializeField] private Key[] KeysStats;
    [SerializeField] GameObject selectManag;

    [SerializeField] GameObject exit;
    [SerializeField] FirstPersonController player;

    private bool isPaused = false;
    #endregion

    private void Awake() {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
    public bool KeyStatus(int key)
    {

        return KeysStats[key].GetKeyStatus();   
    }

    void Update(){
        
        if(Input.GetKeyDown(KeyCode.Escape) && !isPaused){
            PauseMain();
            isPaused = !isPaused;
        }

        if(Input.GetMouseButtonDown(0) && isPaused){
            UnpauseMain();
            isPaused = !isPaused;
        }
    }

    public void PauseMain(){
        Time.timeScale =0;
        player.enabled = !player.enabled;
        selectManag.SetActive(false);
        exit.SetActive(true);
    }

    public void UnpauseMain(){
        Time.timeScale =1.0f;
        player.enabled = !player.enabled;
        selectManag.SetActive(true);
        exit.SetActive(false);
    }
}
