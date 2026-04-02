using UnityEngine;

public abstract class AIPlayer : Player
{
	protected abstract Card processNextMove(Field field);

	public override void BeginTurn()
	{
		_ = inTurn();
	}

	public override void EndTurn()
	{

	}

	protected void calculate

	protected async void inTurn()
	{
		for(int i = 0; i < 10; ++i)
		{
			Card nextCard = processNextMove(m_gameManager.GetField());

			if(!nextCard)
			{
				break;
			}

			DoMove(nextCard);
		}

		m_gameManager.NextTurn();

	}
}
