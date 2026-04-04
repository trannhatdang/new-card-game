using UnityEngine;

[CreateAssetMenu(fileName = "TestCharacter", menuName = "ScriptableObjects/CharacterCard/TestCharacter")]
public class TestCharacter : CharacterCard
{
	public override void CardAction(CardInfoSO card, Player player, GameManager gm, UIManager ui, Player targetPlayer = null)
	{
		card.CardAction(player, gm, ui, targetPlayer);
	}
}
