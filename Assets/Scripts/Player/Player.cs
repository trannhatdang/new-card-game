using UnityEngine;

public abstract class Player : MonoBehaviour
{
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	[SerializeField] protected GameManager m_gameManager;
	[SerializeField] protected Hand m_hand;
	[SerializeField] protected string m_name;

	public abstract void BeginTurn();
	public abstract void EndTurn();

	protected async void DoMove(Card card, int targetPlayerIndex)
	{
		if(!card || !m_hand.ContainsCard(card))
		{
			return;
		}

		Player targetPlayer = m_gameManager.GetPlayer(targetPlayerIndex);

		card.OnPlayed();
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

	public string Print()
	{
		return m_name;
	}
}
