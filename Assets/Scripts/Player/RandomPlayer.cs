using UnityEngine;
using Cysharp.Threading.Tasks;

public class RandomPlayer : AIPlayer
{
	protected override async UniTask<Move> processNextMove(Field field)
	{
		int size = m_hand.GetNumCardsLeft();
		int nextCard = Random.Range(0, size);
		int targetPlayer = Random.Range(0, 4);

		return new Move(nextCard, targetPlayer);
	}
}
