public struct Move
{
	public int nextCard;
	public int targetPlayer;

	public Move(int nextCard, int targetPlayer)
	{
		this.nextCard = nextCard;
		this.targetPlayer = targetPlayer;
	}
}
