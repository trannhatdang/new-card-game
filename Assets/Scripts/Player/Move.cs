using UnityEngine;

public struct Move
{
	public int nextCard;
	public int targetPlayer;
	public Vector2 targetCard;

	public Move(int nextCard, int targetPlayer, Vector2 targetCard)
	{
		this.nextCard = nextCard;
		this.targetPlayer = targetPlayer;
		this.targetCard = targetCard;
	}
}
