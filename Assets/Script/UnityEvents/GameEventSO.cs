using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Event", menuName = "GameEventSO/New Event")]
public class GameEventSO : ScriptableObject
{
    //yapacagımız evente göre farklı farklı observer yaratabiliriz burası observer yani dinleyici yerimiz örneğin kapının açıldığında yapılmasını istediğimiz
    //tüm olayları bu scriptable objeye ekliyeceğiz ve ve çağırmak istediğimiz sınıfa bu scriptable objeyi atıp invokevet methodunu çalıştıracağız 
    HashSet<EventListener> events; //HashSet list gibidir tek farkı ayni objeyi iki kere eklemez 

    private void OnEnable()
    {
        events = new HashSet<EventListener>();
    }
    public void AddEvent(EventListener eventListener)//örnegin kapı açıldığında yapılacak olan eventler ekleniyor
    {
        events.Add(eventListener);
    }
    public void RemoveEvent(EventListener eventListener)//örnegin kapı açıldığında artık yapılmasın dediğin eventler çıkartılıyor
    {
        if (events.Contains(eventListener))
        {
            events.Remove(eventListener);
        }
    }
    public void InvokeEvent()// kapının açıldığı sınıfta kapı açılır açılmaz çağırılıyor
    {
        foreach (var eventListener in events)
        {
            eventListener.Notify();
        }
    }
}
