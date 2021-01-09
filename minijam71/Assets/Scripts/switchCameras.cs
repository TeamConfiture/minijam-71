using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchCameras : MonoBehaviour
{

    public Camera camera1;
    public Camera camera2;

    // Start is called before the first frame update
    void Start()
    {
        camera1.enabled = true;
        camera2.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {

        camera2.enabled = !(camera2.enabled);
        camera1.enabled = !(camera1.enabled);
    }
}
