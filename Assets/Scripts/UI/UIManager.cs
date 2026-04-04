using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Cysharp.Threading.Tasks;

public class UIManager : MonoBehaviour
{
	[SerializeField] GameManager m_gameManager;
	[SerializeField] UIRightClickMenu m_rightClickMenu;
	[SerializeField] List<UIHand> m_handList;

	public void PickPlayer(Player player)
	{
		m_gameManager.PickPlayer(player);
	}

	public void PickCard(Card card)
	{
		m_gameManager.PickCard(card);
	}

	public void OpenRightClickMenu(UICard card)
	{
		m_rightClickMenu.Open(card);
	}
}
