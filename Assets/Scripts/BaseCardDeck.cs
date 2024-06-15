using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class BaseCardDeck
{
    private List<BaseCard> cards;

    public BaseCardDeck()
    {
        cards = new List<BaseCard>();
    }

    public virtual bool AddCard(BaseCard card)
    {
        cards.Add(card);
        UnityEngine.Debug.Log($"Card added to the deck: {card.CardName}");
        return true;
    }

    public void RemoveCard(BaseCard card)
    {
        cards.Remove(card);
    }

    public void CardShuffle()
    {
        Random rnd = new Random();
        int n = cards.Count;
        while (n > 1)
        {
            n--;
            int k = rnd.Next(n + 1);
            BaseCard value = cards[k];
            cards[k] = cards[n];
            cards[n] = value;
        }
    }

    // Add other methods and properties as needed

}