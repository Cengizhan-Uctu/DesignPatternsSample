using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Event", menuName = "GameEventSO/New Event")]
public class GameEventSO : ScriptableObject
{
   
    HashSet<EventListener> events; 
    private void OnEnable()
    {
        events = new HashSet<EventListener>();
    }
    public void AddEvent(EventListener eventListener)
    {
        events.Add(eventListener);
    }
    public void RemoveEvent(EventListener eventListener)
    {
        if (events.Contains(eventListener))
        {
            events.Remove(eventListener);
        }
    }
    public void InvokeEvent()
    {
        foreach (var eventListener in events)
        {
            eventListener.Notify();
        }
    }
}
