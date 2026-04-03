using UnityEngine;

public class RandomPlayer : AIPlayer
{
	protected override async void processNextMove(Field field, out int nextCard, out int targetPlayer)
	{
		nextCard = Random.Range(0, size);
		targetPlayer = Random.Range(0, 4);
	}
}
