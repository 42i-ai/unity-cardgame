using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawFellowshipHand : MonoBehaviour
{

    private string single_line;
    private string double_line;
    [SerializeField]
    private BaseCardDeck fellowshipDeck;
    [SerializeField]
    private CardDeck fellowshipHand;
    [SerializeField]
    public BaseCardDeck FellowshipDeck { get => fellowshipDeck; set => fellowshipDeck = value; }

    // Start is called before the first frame update
    void Start()
    {
        fellowshipHand = new CardDeck();
        single_line = new string('-', 50);
        double_line = new string('=', 50);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        UnityEngine.Debug.Log(single_line);
        UnityEngine.Debug.Log("Fellowship Player");
        if (fellowshipHand.Cards.Count < 10)
        {
            BaseCard card = fellowshipDeck.GetTopCard();
            UnityEngine.Debug.Log(single_line);
            if (card == null)
            {
                UnityEngine.Debug.Log("No cards in the deck!");
                return;
            }
            else
            {
                if (fellowshipHand.AddCard(card) == true)
                {
                    fellowshipDeck.RemoveTopCard();
                    UnityEngine.Debug.Log($"Added card to your hand: {card.CardName}");
                }
                else if (fellowshipHand.AddCard(card) == false)
                {
                    UnityEngine.Debug.Log("You cannot take this card!");
                    fellowshipDeck.CardShuffle();
                }

            }
        }
        else
        {
            UnityEngine.Debug.Log("You already took all the cards!");
        }
        UnityEngine.Debug.Log($"My hand {fellowshipHand.Cards.Count} cards");
        UnityEngine.Debug.Log($"Fellowship deck  {fellowshipDeck.Cards.Count} cards");

        UnityEngine.Debug.Log(double_line);


    }
}
