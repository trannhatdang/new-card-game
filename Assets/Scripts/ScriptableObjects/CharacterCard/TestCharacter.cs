using UnityEngine;

[CreateAssetMenu(fileName = "TestCharacter", menuName = "ScriptableObjects/CharacterCard/TestCharacter")]
public class TestCharacter : CharacterCard
{
	public override void CardAction(CardInfoSO card, Player player, GameManager gm, Player targetPlayer = null, Card targetCard = null)
	{
		card.CardAction(player, gm, targetPlayer, targetCard);
	}

	public override void CardAction(CardInfoSO card, Player player, Field field, Player targetPlayer = null, Card targetCard = null)
	{

	}
}
