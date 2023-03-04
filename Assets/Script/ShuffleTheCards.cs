using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuffleTheCards : Singleton<ShuffleTheCards>
{
    [SerializeField] int cardCount;
    public List<int> cardNumbers = new List<int>();
    private void Start()
    {
        ShuffleCards();
    }
    public void ShuffleCards()
    {
        while (cardNumbers.Count<=cardCount)
        {
            int number = Random.Range(0, cardCount + 1);
            if (!cardNumbers.Contains(number))
            {
                cardNumbers.Add(number);
            }
        }
    }
}
