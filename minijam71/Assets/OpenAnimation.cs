using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAnimation : MonoBehaviour
{
    private bool opened = false;
    private bool opening = false;
    private float ratio = 5f;
    float lerpValue = 0;
    Vector3 from;
    Vector3 to;

    void start()
    {
        from = transform.position;
        to = from + new Vector3(3f,0f,0f);
    }


    public void OpenDoor()
     {
         if (!opened)
         {
            opening = true;
            opened = true;
         }

     }
     private void Update() {
            if(opening)
            {
                if(lerpValue < 1 )
                {
                    lerpValue += Time.deltaTime / ratio;
                    transform.position = Vector3.Lerp(from, to, lerpValue);
                }
                
            }
            
     }
}
