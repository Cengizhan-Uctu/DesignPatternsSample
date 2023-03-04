using UnityEngine.AI;
using UnityEngine;
using System.Collections.Generic;
using TMPro;
public class CustomerAISM : StateMachine
{
    public Idle idle;
    public Moving moving;
    public TakeCard takeCard;
    public GoChair goChair;
    public Listener listener;
    public NavMeshAgent navmashAgent;
    public Transform target;
    public Transform hand;

    public List<int> cardNumber = new List<int>();
    public Transform cardNumberTextTrasform;
    public TextMeshProUGUI cardNumberText;
    public TextMeshProUGUI cardNumberText2;
    public GameObject cardObject;
    private void Awake()
    {
        idle = new Idle(this);
        moving = new Moving(this);
        takeCard = new TakeCard(this);
        goChair = new GoChair(this);
        listener = new Listener(this);
    }
    protected override BaseState GetInitalState()
    {
        return idle;
    }
}
