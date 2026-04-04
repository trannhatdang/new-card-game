using UnityEngine;

public abstract class CharacterCard : ScriptableObject
{
	public abstract void CardAction(CardInfoSO card, Player player, GameManager gm, UIManager ui, Player targetPlayer = null);
}
