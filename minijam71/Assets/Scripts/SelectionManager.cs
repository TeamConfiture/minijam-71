using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

///<summary>created with https://www.youtube.com/watch?v=_yf5vzZ2sYE</summary>
public class SelectionManager : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable";

    private Transform _selection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_selection != null)
        {
            var selectionOutline = _selection.GetComponent<Outline>();
            selectionOutline.OutlineWidth = 0f;
            _selection = null;
        }

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        if (Physics.Raycast(ray, out hit, 5))
        {
            //3D Model must have Selectable Tag !!!
            if (hit.transform.CompareTag(selectableTag))
            {
                var selection = hit.transform.parent;

                var selectionOutline = selection.GetComponent<Outline>();
                selectionOutline.OutlineWidth = 7f;
                    
                if (Input.GetMouseButtonDown(0))
                {
                   selection.GetComponent<EventOnClick>().OnClick();
                }
                _selection = selection;
            }

        }
    }
}
