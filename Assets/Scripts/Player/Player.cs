using UnityEngine;

public abstract class Player : MonoBehaviour
{
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	[SerializeField] protected GameManager m_gameManager;
	[SerializeField] protected Hand m_hand;
	[SerializeField] protected string m_name;

	public abstract void BeginTurn();
	public abstract void EndTurn();

	protected void DoMove(Card card)
	{
		if(!card || !m_hand.ContainsCard(card))
		{
			return;
		}

	}

	public void InjectGameManager(GameManager gameManager)
	{
		if(m_gameManager)
		{
			return;
		}

		m_gameManager = gameManager;
	}

	public string Print()
	{
		return m_name;
	}
}
