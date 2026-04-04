using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;

public abstract class AIPlayer : Player
{
	protected abstract UniTask<Move> processNextMove(Field field);

	public override void BeginTurn()
	{
		inTurn();
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

			int nextCard = -1;
			int targetPlayer = -1;

			Move move = await processNextMove(m_gameManager.GetField());

			if(move.nextCard < 0 || move.nextCard > size)
			{
				break;
			}

			await DoMove(move);
		}

		m_gameManager.NextTurn();

	}
}
