using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventListener : MonoBehaviour
{
    //bu sınıf aslında bir köprü görevini görüyor çalıştırmak istediğimiz methodun bağlı olduğu sınıfı unityEvent sayesinde çekiyor ve bu methodu 
    //ekleyip çıkartıyoruz 
    [SerializeField] UnityEvent unityEvent;//kapı açıldığında çalışmasını istediğin methodun bağlı oldugu sınıfı atabilirsin
    [SerializeField] GameEventSO gameEventSO;
    private void OnEnable()
    {
        gameEventSO.AddEvent(this);// bu sınıfı istediğimiz evetsc ye ekliyoruz  
    }
    private void OnDisable()// obje kapatıldığında çıkartıyoruz   
    {
        gameEventSO.RemoveEvent(this);
    }
    // burada unity eventi tetikliyoruz bu istediğimiz methodun bir kere çalıştırlması demek yani eventso yada listener herhangi sınıflar
    //burada asıl evet işlemi gerçekleşiyor
    public void Notify()

    {
        unityEvent.Invoke();
    }
}
