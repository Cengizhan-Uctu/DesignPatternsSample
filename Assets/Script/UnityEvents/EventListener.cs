using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventListener : MonoBehaviour
{
   
    [SerializeField] UnityEvent unityEvent;
    [SerializeField] GameEventSO gameEventSO;
    private void OnEnable()
    {
        gameEventSO.AddEvent(this); 
    }
    private void OnDisable()
    {
        gameEventSO.RemoveEvent(this);
    }
   
    public void Notify()

    {
        unityEvent.Invoke();
    }
}
