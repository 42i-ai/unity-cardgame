using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawSauronHand : MonoBehaviour
{


    private string single_line;
    private string double_line;
    [SerializeField]
    private BaseCardDeck sauronDeck;
    [SerializeField]
    private CardDeck sauronHand;
    [SerializeField]
    public BaseCardDeck SauronDeck { get => sauronDeck; set => sauronDeck = value; }
    // Start is called before the first frame update
    void Start()
    {
        sauronHand = new CardDeck();
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
        UnityEngine.Debug.Log("Sauron Player");
        if (sauronHand.Cards.Count < 10)
        {
            BaseCard card = sauronDeck.GetTopCard();
            UnityEngine.Debug.Log(single_line);
            if (card == null)
            {
                UnityEngine.Debug.Log("No cards in the deck!");
                return;
            }
            else
            {
                if (sauronHand.AddCard(card) == true)
                {
                    sauronDeck.RemoveTopCard();
                    UnityEngine.Debug.Log($"Added card to your hand: {card.CardName}");
                }
                else if (sauronHand.AddCard(card) == false)
                {
                    UnityEngine.Debug.Log("You cannot take this card!");
                    sauronDeck.CardShuffle();
                }

            }
        }
        else
        {
            UnityEngine.Debug.Log("You already took all the cards!");
        }
        UnityEngine.Debug.Log($"My hand {sauronHand.Cards.Count} cards");
        UnityEngine.Debug.Log($"Sauron deck  {sauronDeck.Cards.Count} cards");

        UnityEngine.Debug.Log(double_line);
    }
}