using UnityEngine;
using System;
public enum CardRarity
{
    Normal,
    Rare,
    Legendary
}

[System.Serializable]
public class BaseCard
{
    [SerializeField]
    private string cardName;
    public string CardName
    {
        get { return cardName; }
        set { cardName = value; }
    }

    [SerializeField]
    private int cardCost;
    public int CardCost
    {
        get { return cardCost; }
        set { cardCost = value; }
    }

    [SerializeField]
    private CardRarity rarity;
    public CardRarity Rarity
    {
        get { return rarity; }
        set { rarity = value; }
    }

    // Constructor for the Card class
    public BaseCard(string cardName, int cardCost, CardRarity rarity)
    {
        this.cardName = cardName;
        this.cardCost = cardCost;
        this.rarity = rarity;
    }
}
