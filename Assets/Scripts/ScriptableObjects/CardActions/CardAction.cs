using UnityEngine;

[CreateAssetMenu(fileName = "CardActionSO", menuName = "ScriptableObjects/CardAction")]
public class CardAction : ScriptableObject
{
	public virtual void Action(Player player, GameManager gm, Player targetPlayer = null, Card targetCard = null)
	{

	}

	public virtual void Action(Player player, Field field, Player targetPlayer = null, Card targetCard = null)
	{

	}

	public virtual bool OnDodge()
	{
		return false;
	}

	public virtual void SetRightClickOptions(UIRightClickMenu menu)
	{

	}
}
