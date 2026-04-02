using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Hand : MonoBehaviour
{
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	[SerializeField] List<Card> m_cardList;
	[SerializeField] UIHand m_UIHand;

	public List<Card> CardList {
		get { return m_cardList; }
	}

	public int GetNumCardsLeft()
	{
		return m_cardList.Count;
	}

	public bool ContainsCard(Card card)
	{
		return m_cardList.Contains(card);
	}
}
