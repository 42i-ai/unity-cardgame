using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

public class CardDeck : BaseCardDeck
{
    private const int MaxCards = 10;
    private const int MaxLegendaries = 2;
    private const int MaxRares = 1;

    private int CountLengendaries()
    {
        int legendaryCount = 0;

        foreach (CreatureCard card in Cards)
        {
            if (card.Rarity == CardRarity.Legendary)
            {
                legendaryCount++;
            }
        }
        return legendaryCount;
    }

    private int CountRares()
    {
        int rareCount = 0;

        foreach (CreatureCard card in Cards)
        {
            if (card.Rarity == CardRarity.Rare)
            {
                rareCount++;
            }
        }
        return rareCount;
    }

    public List<BaseCard> Cards { get; private set; }

    public CardDeck()
    {
        Cards = new List<BaseCard>();
    }

    public new bool AddCard(BaseCard card)
    {

        if (Cards.Count < MaxCards)
        {
            if (card is CreatureCard)
            {
                CreatureCard creature = card as CreatureCard;

                if (creature.Rarity == CardRarity.Legendary && CountLengendaries() < MaxLegendaries)
                {
                    Cards.Add(creature);
                    UnityEngine.Debug.Log($"Added Legendary creature: {creature.CardName} to your deck! The deck has total power of {CalculateTotalValue()} ");
                    return true;
                }
                else if (creature.Rarity == CardRarity.Rare && CountRares() < MaxRares)
                {
                    Cards.Add(creature);
                    UnityEngine.Debug.Log($"Added Rare creature: {creature.CardName} to your deck! The deck has total power of {CalculateTotalValue()} ");
                    return true;
                }
                else if (creature.Rarity == CardRarity.Normal)
                {
                    Cards.Add(creature);
                    UnityEngine.Debug.Log($"Added creature: {creature.CardName} to your deck! The deck has total power of {CalculateTotalValue()} ");
                    return true;
                }
            }
        }
        else
        {
            UnityEngine.Debug.Log("Your Deck is full");
        }
        return false;
    }

    public int CalculateTotalValue()
    {
        int totalPower = 0;
        foreach (BaseCard card in Cards)
        {
            totalPower += card.CardCost;
        }
        return totalPower;
    }
}
