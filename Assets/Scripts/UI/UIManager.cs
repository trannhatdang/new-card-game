using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UIManager : MonoBehaviour
{
	[SerializeField] GameManager m_gm;
	[SerializeField] List<UIHand> m_handList;

	public void StartPlayerPicker()
	{
		m_gm.StartPlayerPicker();
	}

	public void StartCardPicker()
	{
		m_gm.StartCardPicker();
	}

	public void PickPlayer(Player player)
	{
		m_gm.PickPlayer(player);
	}

	public void PickCard(Card card)
	{
		m_gm.PickCard(card);
	}

}
