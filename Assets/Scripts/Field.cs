using UnityEngine;

public class Field
{
	public int PlayersLeft = 4;
	public List<PlayerRole> RolesLeft;
	public List<int> PlayersHands;

	public Field(int playersLeft, List<PlayerRole> rolesLeft, List<int> playersHands) : PlayersLeft(playersLeft), RolesLeft(rolesLeft), PlayersHands(playersHands)
	{
		if(!checkValid())
		{
			Debug.Log("Invalid Field Creation!")
		}
	}

	public Field(const Field& field)
	{
		this.PlayersLeft = field.PlayersLeft;
		this.RolesLeft = new List<PlayerRole>(field.RolesLeft);
		this.PlayersHands = new List<int>(field.PlayersHands);

		if(!checkValid())
		{
			Debug.Log("Invalid Field Creation!")
		}
	}

	public void SimulateMove(int player, CardInfoSO card)
	{

	}

	bool checkValid()
	{
		return PlayersLeft != RolesLeft.Count || PlayersLeft != PlayersHands.Count;
	}
}
