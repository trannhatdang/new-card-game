using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "CardInfoSO", menuName = "ScriptableObjects/CardInfoSO")]
public class CardInfoSO : ScriptableObject
{
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	[SerializeField] string m_name;
	[SerializeField] string m_descript;
	[SerializeField] Sprite m_sprite;
	[SerializeField] CardAction m_action;
	
	public void CardAction(Player player, GameManager gm, UIManager ui)
	{
		m_action.Action(player, gm, ui);
	}
}
