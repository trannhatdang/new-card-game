using UnityEngine;

public abstract class AIPlayer : Player
{
	protected abstract void processNextMove(Field field, out int nextCard, out int targetPlayer);

	public override void BeginTurn()
	{
		_ = inTurn();
	}

	public override void EndTurn()
	{

	}

	protected List<Card> getMoves()
	{
		return m_hand.CardList;
	}

	protected async void inTurn()
	{
		for(int i = 0; i < 10; ++i)
		{
			List<Card> cards = getMoves();
			int size = cards.Count;

			int nextCard = null;
			int targetPlayer = -1;

			processNextMove(m_gameManager.GetField(), out nextCard, out targetPlayer);

			if(nextCard < 0 || nextCard > size)
			{
				break;
			}

			await DoMove(cards[nextCard], targetPlayer);
		}

		m_gameManager.NextTurn();

	}
}
