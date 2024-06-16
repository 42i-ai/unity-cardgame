using System;

public class SpellCard : BaseCard
{
  public string Effect { get; private set; }
  public SpellCard(string cardName, int cardCost, CardRarity rarity, string effect) : base(cardName, cardCost, rarity)
  {
    /*
    This can be used to choose especific effect as frost, fire, etc
      - A frozen user cannot attack.
      - A burned user will take damage over time.
    */
    Effect = effect;
    UnityEngine.Debug.Log($"Spell created: {cardName} spell effect {effect} ");
  }

}