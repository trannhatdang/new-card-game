using UnityEngine;

[CreateAssetMenu(fileName = "CardActionSO", menuName = "ScriptableObjects/CardAction")]
public abstract class CardAction : ScriptableObject
{
	public abstract void Action(Player player, GameManager gm, UIManager ui, Player targetPlayer = null);
	public abstract void Action(Player player, Field field, Player targetPlayer = null);
}
