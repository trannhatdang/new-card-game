using UnityEngine;
using Cysharp.Threading.Tasks;

public class MonteCarloPlayer : AIPlayer
{
	protected override async UniTask<Move> processNextMove(Field field)
	{

		return new Move(-1, -1);
	}
}
