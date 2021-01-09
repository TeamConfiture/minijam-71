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
         transform.rotation = Quaternion.LookRotation(new Vector3(-cam.transform.forward.x,0.0f,-cam.transform.forward.z));
     }
}
