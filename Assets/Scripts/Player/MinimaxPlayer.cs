using UnityEngine;
using Cysharp.Threading.Tasks;

public class MinimaxPlayer : AIPlayer
{
	protected override async UniTask<Move> processNextMove(Field field)
	{

		return new Move(-1, -1, Vector2.zero);
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
