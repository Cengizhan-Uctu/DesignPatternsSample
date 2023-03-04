using System.Collections;
using TMPro;
using System.Collections.Generic;
using UnityEngine;

public class CardData : MonoBehaviour
{
    public List<int> cardNumber = new List<int>();
    private int numerLenth = 2;
    public Transform cardNumberTextTrasform;
    public TextMeshProUGUI cardNumberText;
    public TextMeshProUGUI cardNumberText2;


    private void Start()
    {
        for (int i = 0; i < numerLenth; i++)
        {
            var cardBag = ShuffleTheCards.Instance.cardNumbers;
            cardNumber.Add(cardBag[0]);
            cardBag.Remove(cardBag[0]);
        }

    }
}
