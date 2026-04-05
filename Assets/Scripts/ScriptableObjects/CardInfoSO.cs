using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "CardInfoSO", menuName = "ScriptableObjects/CardInfoSO")]
public class CardInfoSO : ScriptableObject
{
	[SerializeField] string m_name;
	[SerializeField] string m_descript;
	[SerializeField] Sprite m_sprite;
	[SerializeField] CardAction m_action;

	public void CardAction(Player player, GameManager gm, Player targetPlayer = null, Card targetCard = null)
	{
		m_action.Action(player, gm, targetPlayer, targetCard);
	}

	public void SetRightClickOptions(UIRightClickMenu menu)
	{
		m_action.SetRightClickOptions(menu);
	}

	public bool OnDodge()
	{
		return m_action.OnDodge();
	}
}
