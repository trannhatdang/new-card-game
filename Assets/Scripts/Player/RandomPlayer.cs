using UnityEngine;
using Cysharp.Threading.Tasks;

public class RandomPlayer : AIPlayer
{
	protected override async UniTask<Move> processNextMove(Field field)
	{
		int size = m_hand.GetNumCardsLeft();

		int nextCard = Random.Range(0, size);
		int targetPlayer = Random.Range(0, 4);

		Vector2 targetCard = Vector2.zero;

		return new Move(nextCard, targetPlayer, targetCard);
	}

	public override async UniTask<Player> StartPlayerPicker()
	{
		return null;
	}

	public override async UniTask<Card> StartCardPicker()
	{
		return null;
	}
}
