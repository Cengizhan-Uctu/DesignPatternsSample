using UnityEngine;


public class TakeCard : BaseState
{
    private Transform hand;
    public TakeCard(CustomerAISM stateMachine) : base("TakeCard", stateMachine) { hand = stateMachine.hand; }
    public override void Enter()
    {
        base.Enter();
        var Cards = CardController.Instance;
        var Chairs = ChairController.Instance;
        Cards.cards[0].transform.parent = hand;
        ((CustomerAISM)stateMachine).cardNumber = Cards.cards[0].GetComponent<CardData>().cardNumber;
        ((CustomerAISM)stateMachine).cardNumberTextTrasform = Cards.cards[0].GetComponent<CardData>().cardNumberTextTrasform;
        ((CustomerAISM)stateMachine).cardNumberText = Cards.cards[0].GetComponent<CardData>().cardNumberText;
        ((CustomerAISM)stateMachine).cardNumberText2 = Cards.cards[0].GetComponent<CardData>().cardNumberText2;
        ((CustomerAISM)stateMachine).cardObject = Cards.cards[0].GetComponent<CardData>().transform.gameObject;
        Cards.cards.Remove(Cards.cards[0]);
        ((CustomerAISM)stateMachine).target = Chairs.chairs[0].transform;
        Chairs.chairs.Remove(Chairs.chairs[0]);

        ((CustomerAISM)stateMachine).navmashAgent.speed = 3.5f;

        stateMachine.ChangeState(((CustomerAISM)stateMachine).goChair);
    }
}
