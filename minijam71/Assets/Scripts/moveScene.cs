
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class moveScene : MonoBehaviour
{
    public string LevelToLoad;

    // Start is called before the first frame update
    void Start()
    {
        

        //Debug.Log("Started");

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Waiting for collision");
    }

    void OnMouseDown()
    {
        //Debug.Log("Collision detected");

        if(gameObject.tag == "InteractObject"|| gameObject.tag == "InteractObject2")
        {
            SceneManager.LoadScene(LevelToLoad);
        }
        else
        {
            Debug.Log("Not an object you can interact with");
        }
    }
}