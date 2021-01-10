using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAnimation : MonoBehaviour
{
    [SerializeField] private bool isLeft = false;
    private bool opened = false;
    private bool opening = false;
    private float ratio = 5f;
    float lerpValue = 0;
    Vector3 from;
    Vector3 to;

    void Start()
    {
        from = transform.localPosition;
        if (!isLeft)
        {
            to = from + new Vector3(3f,0f,0f);
        }
        else 
        {
            to = from - new Vector3(3f,0f,0f);
        }
        
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
                    transform.localPosition = Vector3.Lerp(from, to, lerpValue);
                }
                if(transform.localPosition == to)
                {
                    opening = false;
                    transform.gameObject.SetActive(false);
                }
                
            }
            
     }
}
