public class CreatureCard : BaseCard
{
    public int AttackPower { get; set; }
    public int Life { get; set; }
    public CreatureCard(string cardName, int cardCost, CardRarity rarity, int attackPower, int life) : base(cardName, cardCost, rarity)
    {
        AttackPower = attackPower;
        life = Life;
        UnityEngine.Debug.Log($"Creature created: {cardName} attack power {attackPower} ");
    }
}
