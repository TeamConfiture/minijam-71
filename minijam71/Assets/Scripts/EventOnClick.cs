using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventOnClick : MonoBehaviour
{
    [SerializeField] private UnityEvent Event;

    public void OnClick() 
    {
        Event.Invoke();
    }
}
