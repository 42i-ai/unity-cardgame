using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject SauronArea;
    public GameObject FellowshipArea;

    private BaseCardDeck sauronDeck;
    private BaseCardDeck fellowshipDeck;

    public GameObject ButtonSauronCardDeck;

    public GameObject ButtonFellowshipCardDeck;


    private DrawFellowshipHand fellowshipHand;

    private DrawSauronHand sauronHand;

    void Start()
    {
        UnityEngine.Debug.Log("Game started");

        sauronDeck = new BaseCardDeck();
        sauronDeck.AddCard(new CreatureCard("Sauron", 8, CardRarity.Legendary, 10, 10));
        sauronDeck.AddCard(new CreatureCard("Witch-king of Angmar", 6, CardRarity.Legendary, 7, 7));
        sauronDeck.AddCard(new CreatureCard("Orc Warrior", 2, CardRarity.Normal, 3, 2));
        sauronDeck.AddCard(new CreatureCard("Uruk-hai Berserker", 3, CardRarity.Rare, 5, 3));
        sauronDeck.AddCard(new CreatureCard("Nazgûl", 5, CardRarity.Rare, 6, 5));
        sauronDeck.AddCard(new CreatureCard("Orc Archer", 3, CardRarity.Normal, 4, 2));
        sauronDeck.AddCard(new CreatureCard("Troll", 7, CardRarity.Rare, 8, 8));
        sauronDeck.AddCard(new CreatureCard("Gorbag", 4, CardRarity.Rare, 5, 4));
        sauronDeck.AddCard(new CreatureCard("Orc Captain", 3, CardRarity.Normal, 3, 4));
        sauronDeck.AddCard(new CreatureCard("Mûmakil", 6, CardRarity.Rare, 7, 6));
        sauronDeck.AddCard(new CreatureCard("Uruk-hai Scout", 2, CardRarity.Normal, 3, 3));
        sauronDeck.AddCard(new CreatureCard("Olog-hai", 5, CardRarity.Rare, 6, 7));
        sauronDeck.AddCard(new CreatureCard("Haradrim Warrior", 3, CardRarity.Normal, 4, 3));
        sauronDeck.AddCard(new CreatureCard("Corsair of Umbar", 3, CardRarity.Normal, 4, 3));
        sauronDeck.AddCard(new CreatureCard("Mouth of Sauron", 5, CardRarity.Rare, 5, 5));
        sauronDeck.AddCard(new CreatureCard("Khamûl the Easterling", 6, CardRarity.Rare, 6, 6));
        sauronDeck.AddCard(new CreatureCard("Easterling Soldier", 3, CardRarity.Normal, 4, 3));
        sauronDeck.AddCard(new CreatureCard("Gothmog", 5, CardRarity.Rare, 5, 6));
        sauronDeck.AddCard(new CreatureCard("Grishnákh", 4, CardRarity.Rare, 4, 5));
        sauronDeck.AddCard(new CreatureCard("Morgul Rat", 2, CardRarity.Normal, 2, 3));
        sauronDeck.AddCard(new SpellCard("Darkness Unleashed", 4, CardRarity.Rare, "Reduce the attack power of all enemy creatures by 3 for 2 turns"));
        sauronDeck.AddCard(new SpellCard("Mordor's Call", 3, CardRarity.Normal, "Summon two Orc Warriors with 3 attack and 2 health"));
        sauronDeck.AddCard(new SpellCard("Ring of Power", 6, CardRarity.Legendary, "Double the attack power of all your creatures for 1 turn"));
        sauronDeck.AddCard(new SpellCard("Flames of Mount Doom", 5, CardRarity.Rare, "Deal 5 damage to all enemy creatures and destroy the One Ring if it is in play"));
        sauronDeck.AddCard(new SpellCard("Summon Balrog", 7, CardRarity.Legendary, "Summon a Balrog creature with 8 attack and 8 health"));

        sauronDeck.CardShuffle();

        fellowshipDeck = new BaseCardDeck();
        // Criaturas
        fellowshipDeck.AddCard(new CreatureCard("Frodo Baggins", 3, CardRarity.Rare, 2, 5));
        fellowshipDeck.AddCard(new CreatureCard("Gandalf the Grey", 7, CardRarity.Legendary, 6, 8));
        fellowshipDeck.AddCard(new CreatureCard("Aragorn", 5, CardRarity.Rare, 5, 7));
        fellowshipDeck.AddCard(new CreatureCard("Legolas", 4, CardRarity.Normal, 4, 4));
        fellowshipDeck.AddCard(new CreatureCard("Gimli", 4, CardRarity.Normal, 5, 4));
        fellowshipDeck.AddCard(new CreatureCard("Boromir", 5, CardRarity.Rare, 6, 5));
        fellowshipDeck.AddCard(new CreatureCard("Samwise Gamgee", 3, CardRarity.Normal, 2, 6));
        fellowshipDeck.AddCard(new CreatureCard("Meriadoc Brandybuck", 2, CardRarity.Normal, 2, 3));
        fellowshipDeck.AddCard(new CreatureCard("Peregrin Took", 2, CardRarity.Normal, 2, 3));
        fellowshipDeck.AddCard(new CreatureCard("Éomer", 5, CardRarity.Rare, 5, 6));
        fellowshipDeck.AddCard(new CreatureCard("Faramir", 4, CardRarity.Rare, 4, 5));
        fellowshipDeck.AddCard(new CreatureCard("Théoden", 6, CardRarity.Rare, 6, 7));
        fellowshipDeck.AddCard(new CreatureCard("Galadriel", 7, CardRarity.Legendary, 4, 8));
        fellowshipDeck.AddCard(new CreatureCard("Elrond", 6, CardRarity.Legendary, 5, 7));
        fellowshipDeck.AddCard(new CreatureCard("Arwen", 5, CardRarity.Rare, 4, 6));
        fellowshipDeck.AddCard(new CreatureCard("Haldir", 4, CardRarity.Normal, 4, 4));
        fellowshipDeck.AddCard(new CreatureCard("Treebeard", 6, CardRarity.Rare, 5, 8));
        fellowshipDeck.AddCard(new CreatureCard("Gollum", 3, CardRarity.Normal, 3, 3));
        fellowshipDeck.AddCard(new CreatureCard("Bilbo Baggins", 3, CardRarity.Rare, 2, 4));
        fellowshipDeck.AddCard(new CreatureCard("Eowyn", 4, CardRarity.Rare, 4, 5));

        // Feitiços
        fellowshipDeck.AddCard(new SpellCard("Light of Eärendil", 3, CardRarity.Rare, "Repel all dark creatures for 1 turn"));
        fellowshipDeck.AddCard(new SpellCard("Elven Healing", 4, CardRarity.Normal, "Restore 5 health to a creature"));
        fellowshipDeck.AddCard(new SpellCard("Rohan's Charge", 5, CardRarity.Rare, "Increase the attack power of all your creatures by 3 for 1 turn"));
        fellowshipDeck.AddCard(new SpellCard("Gondor's Valor", 4, CardRarity.Normal, "Increase the health of all your creatures by 2"));
        fellowshipDeck.AddCard(new SpellCard("Istari Wisdom", 6, CardRarity.Legendary, "Draw 3 cards and reduce their cost by 2 for this turn"));

        fellowshipDeck.CardShuffle();


        fellowshipHand = ButtonFellowshipCardDeck.GetComponent<DrawFellowshipHand>();
        if (fellowshipHand != null)
        {
            fellowshipHand.FellowshipDeck = fellowshipDeck;
        }

        sauronHand = ButtonSauronCardDeck.GetComponent<DrawSauronHand>();
        if (sauronHand != null)
        {
            sauronHand.SauronDeck = sauronDeck;
        }




    }


    // Update is called once per frame
    void Update()
    {

    }
}
