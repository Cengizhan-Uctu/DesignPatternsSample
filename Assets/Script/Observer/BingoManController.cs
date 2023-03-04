using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BingoManController : MonoBehaviour
{
    [SerializeField] int cardCount;
    private List<int> baggCards = new List<int>();
    private void Start()
    {
        ShuffleBagg();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            StartCoroutine(GetCardFromBagg());
        }
    }
    IEnumerator GetCardFromBagg()
    {
        while (baggCards.Count>0)
        {
            ConcreteSubject.Instance.NotifyDelegate(baggCards[0]);// etrafa çektiğimiz sayıyı bağırdık
            baggCards.Remove(baggCards[0]);
            yield return new WaitForSeconds(2);
        }
     
    }
    public void ShuffleBagg()
    {
        while (baggCards.Count <= cardCount)
        {
            int number = Random.Range(0, cardCount + 1);
            if (!baggCards.Contains(number))
            {
                baggCards.Add(number);
            }
        }
    }
}
