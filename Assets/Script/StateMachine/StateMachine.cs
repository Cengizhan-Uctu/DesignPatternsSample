using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    BaseState currentState;
    void Start()
    {
        currentState = GetInitalState();
        if (currentState != null)
        {
            currentState.Enter();
        }
    }


    void Update()
    {
        if (currentState != null)
        {
            currentState.UpdateLogic();
        }

    }
    private void LateUpdate()
    {
        if (currentState != null)
        {
            currentState.UpdateLogic();
        }
    }
    public void ChangeState(BaseState newState)
    {
        currentState.Exit();
        currentState = newState;
        currentState.Enter();
    }
    protected virtual BaseState GetInitalState()
    {
        return null;
    }
    //private void OnGUI()// burası bilgilendime için eğer bir state yoksa uyarı vericek
    //{
    //    string content = currentState != null ? currentState.name : "(no current state)";
    //    GUILayout.Label($"<color='black'><size=40>{content}</size></color>");
    //}
}
