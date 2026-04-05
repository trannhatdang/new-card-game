using UnityEngine;
using UnityEngine.UI;

public class CardInfoSO : ScriptableObject
{
	[SerializeField] string m_name;
	[SerializeField] string m_descript;
	[SerializeField] Sprite m_sprite;

	public virtual async void CardAction(Player player, GameManager gm, Player targetPlayer = null, Card targetCard = null)
	{

	}

	public virtual async void CardAction(Player player, Field field, Player targetPlayer = null, Card targetCard = null)
	{

	}

	public virtual void SetRightClickOptions(UIRightClickMenu menu)
	{

	}

	public virtual bool OnDodge()
	{
		return false;
	}
}
