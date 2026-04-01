using UnityEngine;

public abstract class AIPlayer : Player
{
	protected abstract Card processNextMove();

	public override void BeginTurn()
	{
		_ = InTurn();
	}

	async void InTurn()
	{
		for(int i = 0; i < 10; ++i)
		{
			Card nextCard = processNextMove();

			if(!nextCard)
			{
				break;
			}

			DoMove(nextCard);

			await UniTask.Delay
		}

		m_gameManager.NextTurn();

	}

	public override void EndTurn()
	{

	}
}
