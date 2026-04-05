using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Hand : MonoBehaviour
{
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	[SerializeField] Player m_player;
	[SerializeField] List<Card> m_cardList;
	[SerializeField] List<Card> m_equippedCardList;
	[SerializeField] UIHand m_UIHand;

	public List<Card> CardList
	{
		get { return m_cardList; }
	}

	public List<Card> EquippedCardList
	{
		get { return m_equippedCardList; }
	}

	public int GetNumCardsLeft()
	{
		return m_cardList.Count;
	}

	public bool ContainsCard(Card card)
	{
		return m_cardList.Contains(card);
	}

	public int GetNumEquippedCards()
	{
		return m_equippedCardList.Count;
	}

	public void PlayCard(Card card, Player targetPlayer = null)
	{
		m_player.PlayCard(card, targetPlayer);

		m_cardList.Remove(card);
	}

	public void RemoveCard(Card card)
	{
		m_cardList.Remove(card);
		m_UIHand.RemoveCard(card.transform.parent.transform as RectTransform);
	}
}
