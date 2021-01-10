using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHole : MonoBehaviour
{
    // Start is called before the first frame update
    private GameManager gm;
    public int key;

    private OpenAnimation[] doors;

    private void Awake() {
        gm = GameObject.Find("GameManager").transform.GetComponent<GameManager>();
        doors = transform.GetComponentsInChildren<OpenAnimation>();
    }

    public void unlock()
    {
        if (gm.KeyStatus(key) == true)
        {
            foreach(OpenAnimation D in doors)
            {
                D.OpenDoor();
            }
        }
        else {Debug.Log("you shall not pass!");}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
