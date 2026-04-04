using UnityEngine;
using Cysharp.Threading.Tasks;

public abstract class Player : MonoBehaviour
{
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	[SerializeField] protected GameManager m_gameManager;
	[SerializeField] protected UIManager m_UIManager;
	[SerializeField] protected CharacterCard m_characterCard;
	[SerializeField] protected PlayerRole m_role;
	[SerializeField] protected Hand m_hand;
	[SerializeField] protected string m_name;

	public abstract void BeginTurn();
	public abstract void EndTurn();

	protected async UniTask DoMove(Move move)
	{
		Player targetPlayer = m_gameManager.GetPlayer(move.targetPlayer);
		Card card = m_hand.CardList[move.nextCard];

		PlayCard(card, targetPlayer);

		// card.OnPlayed(targetPlayer);
	}

	public void InjectGameManager(GameManager gameManager)
	{
		if(m_gameManager)
		{
			return;
		}

		m_gameManager = gameManager;
	}

	public int GetNumCardsLeft()
	{
		return m_hand.GetNumCardsLeft();
	}

	public int GetEquippedNumCards()
	{
		return m_hand.GetEquippedNumCards();
	}

	public string Print()
	{
		return m_name;
	}

	public void PlayCard(Card m_card, Player targetPlayer)
	{
		m_characterCard.CardAction(m_card.CardInfo, this, m_gameManager, m_UIManager, targetPlayer);
	}
}
