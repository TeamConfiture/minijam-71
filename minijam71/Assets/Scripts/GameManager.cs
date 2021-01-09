using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>This object is singleton. It is Suposed to make sure that every data are correctly transmitted between all scenes
///and that the representations are correctly handled according to player progression</summary>
public class GameManager : MonoBehaviour
{
    #region atributes
    private static GameManager instance;
    ///Contain all nodes of story to keep track of player progression
    #endregion

    private void Awake() {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
