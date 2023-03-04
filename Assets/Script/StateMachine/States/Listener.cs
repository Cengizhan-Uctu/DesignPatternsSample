using System.Collections;
using TMPro;
using System.Collections.Generic;
using UnityEngine;

public class Listener : BaseState
{
    public Listener(CustomerAISM stateMachine) : base("Listener", stateMachine) { }
    private List<int> cardNumber = new List<int>();
    private Transform cardNumberTextTrasform;
    private GameObject cardObject;
    private TextMeshProUGUI cardNumberText, cardNumberText2;
    public override void Enter()
    {
        base.Enter();
        cardNumber = ((CustomerAISM)stateMachine).cardNumber;
        cardNumberTextTrasform = ((CustomerAISM)stateMachine).cardNumberTextTrasform;
        cardNumberText = ((CustomerAISM)stateMachine).cardNumberText;
        cardNumberText2 = ((CustomerAISM)stateMachine).cardNumberText2;
        cardObject = ((CustomerAISM)stateMachine).cardObject;
        cardNumberText.text = cardNumber[0].ToString();
        cardNumberText2.text = cardNumber[1].ToString();

        
        ConcreteSubject.Instance.AddDelegate(CheckNumber);
    }
    public override void UpdateLogic()
    {
        base.UpdateLogic();
        cardNumberTextTrasform.position = Camera.main.WorldToScreenPoint(cardObject.transform.position + Vector3.up);
    }
    void CheckNumber(int number)
    {
        if (number == cardNumber[0])
        {
            Debug.Log("1.sayı doğru"+cardObject.name);
            cardNumberText.faceColor = Color.red;
        }
        if (number == cardNumber[1])
        {
            Debug.Log("2.sayı doğru" + cardObject.name);
            cardNumberText2.faceColor = Color.red;
        }
    }
    public override void Exit()
    {
        base.Exit();
        ConcreteSubject.Instance.RemoveDelegate(CheckNumber);
    }

}
