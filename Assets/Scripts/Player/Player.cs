using UnityEngine;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;

public abstract class Player : MonoBehaviour
{
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	[SerializeField] protected GameManager m_gameManager;
	[SerializeField] protected UIManager m_UIManager;
	[SerializeField] protected CharacterCard m_character;
	[SerializeField] protected PlayerRole m_role;
	[SerializeField] protected Hand m_hand;
	[SerializeField] protected string m_name;
	[SerializeField] protected int m_hp;

	public int HP
	{
		get { return m_hp; }
		set { m_hp = value; }
	}

	public CharacterCard Character
	{
		get { return m_character; }
	}

	public List<Card> CardList
	{
		get { return m_hand.CardList; }
	}

	public abstract void BeginTurn();
	public abstract void EndTurn();
	public abstract UniTask<Player> StartPlayerPicker();
	public abstract UniTask<Card> StartCardPicker();
	public void InjectGameManager(GameManager gameManager)
	{
		if (m_gameManager)
		{
			return;
		}

		m_gameManager = gameManager;
	}

	protected async UniTask DoMove(Move move)
	{
		Player targetPlayer = m_gameManager.GetPlayer(move.targetPlayer);
		Card card = m_hand.CardList[move.nextCard];

		PlayCard(card, targetPlayer);

		// card.OnPlayed(targetPlayer);
	}

	public void PlayCard(Card m_card, Player targetPlayer = null, Card targetCard = null)
	{
		m_character.CardAction(m_card.CardInfo, this, m_gameManager, targetPlayer, targetCard);
	}

	public async UniTask<bool> Shot(Player shooter, int requiredDodges = 1)
	{
		return m_character.ShotReaction(this, m_gameManager, shooter, requiredDodges);
	}

	public int GetNumCardsLeft()
	{
		return m_hand.GetNumCardsLeft();
	}

	public int GetNumEquippedCards()
	{
		return m_hand.GetNumEquippedCards();
	}

	public string Print()
	{
		return m_name;
	}
}
