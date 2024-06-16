using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BaseCardDeck
{
    [SerializeField]
    public List<BaseCard> Cards { get; private set; }

    public BaseCardDeck()
    {
        Cards = new List<BaseCard>();
    }

    public virtual bool AddCard(BaseCard card)
    {
        Cards.Add(card);
        UnityEngine.Debug.Log($"Card added to the deck: {card.CardName}");
        return true;
    }

    public void RemoveTopCard()
    {
        if (Cards.Count > 0)
        {
            BaseCard card = Cards[0];
            UnityEngine.Debug.Log($"Card removed from the deck: {card.CardName}");
            Cards.RemoveAt(0);
        }

    }

    public BaseCard GetTopCard()
    {
        UnityEngine.Debug.Log($"Getting the top card... {Cards.Count} cards in the deck.");
        if (Cards.Count == 0)
        {
            UnityEngine.Debug.Log($"No cards in the deck!");
            return null;
        }

        BaseCard card = Cards[0];
        UnityEngine.Debug.Log($"This is my top card: {card.CardName}");
        return card;
    }

    public void CardShuffle()
    {
        System.Random rnd = new System.Random();
        int n = Cards.Count;
        while (n > 1)
        {
            n--;
            int k = rnd.Next(n + 1);
            BaseCard value = Cards[k];
            Cards[k] = Cards[n];
            Cards[n] = value;
        }
    }

    // Add other methods and properties as needed

}