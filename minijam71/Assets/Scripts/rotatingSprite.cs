using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatingSprite : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Camera cam;
     
    void Update () {
         transform.rotation = Quaternion.LookRotation(-cam.transform.forward);
     }
}
