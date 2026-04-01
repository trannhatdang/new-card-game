using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Cysharp.Threading.Tasks;

public class UIManager : MonoBehaviour
{
	[SerializeField] GameManager m_GM;
	[SerializeField] List<UIHand> m_handList;

	public void PickPlayer(Player player)
	{
		m_GM.PickPlayer(player);
	}

	public void PickCard(Card card)
	{
		m_GM.PickCard(card);
	}
}
