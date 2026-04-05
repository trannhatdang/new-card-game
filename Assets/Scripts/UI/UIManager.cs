using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Cysharp.Threading.Tasks;

public class UIManager : MonoBehaviour
{
	[SerializeField] GameManager m_gameManager;
	[SerializeField] FXManager m_FXManager;

	[SerializeField] UIRightClickMenu m_rightClickMenu;
	[SerializeField] UIPlayerPicker m_playerPicker;
	[SerializeField] List<UIHand> m_handList;

	public void StartPlayerPicker()
	{
		m_playerPicker.SetActive(true);
	}

	public void EndPlayerPicker()
	{
		m_playerPicker.SetActive(false);
	}

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

	public void Pew(Player shooter, Player target)
	{
		m_FXManager.Pew(shooter, target);
	}

	public void Dodge(Player shooter, Player target)
	{
		m_FXManager.Dodge(shooter, target);
	}
}
