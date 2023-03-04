using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteSubject : Singleton<ConcreteSubject>
{
    public delegate void NumberDelegate(int number);
    public NumberDelegate getNumberDelegate;

    public void AddDelegate(NumberDelegate method)
    {
        getNumberDelegate += method;
    }
    public void RemoveDelegate(NumberDelegate method)
    {
        getNumberDelegate -= method;
    }
    public void NotifyDelegate(int number)
    {
        getNumberDelegate(number);
    }

}
