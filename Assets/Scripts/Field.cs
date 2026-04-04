using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Field
{
	public List<PlayerRole> RolesLeft;
	public List<int> PlayersHands;
	public List<int> PlayersEquips;
	public List<int> PlayersHP;
	public List<CharacterCard> PlayersCharacters;
	public List<List<int>> SusMatrix;

	public Field(List<PlayerRole> rolesLeft, List<int> playersHands, List<int> playersEquips, List<int> playersHP,
			List<CharacterCard> playersCharacters, List<List<int>> susMatrix)
	{
		this.RolesLeft = rolesLeft;
		this.PlayersHands = playersHands;
		this.PlayersEquips = playersEquips;
		this.PlayersHP = playersHP;
		this.PlayersCharacters = playersCharacters;
		this.SusMatrix = susMatrix;
	}

	public Field(Field field)
	{
		this.RolesLeft = new List<PlayerRole>(field.RolesLeft);
		this.PlayersHands = new List<int>(field.PlayersHands);
		this.PlayersEquips = new List<int>(field.PlayersEquips);
		this.PlayersHP = new List<int>(field.PlayersHP);
		this.PlayersCharacters = new List<CharacterCard>(field.PlayersCharacters);
		this.SusMatrix = new List<List<int>>(field.SusMatrix);
	}

	public void SimulateMove(int targetPlayer, CardInfoSO card)
	{

	}

	public List<int> CalculateValue()
	{
		List<int> PlayerVal = new List<int>();
		List<int> ret = new List<int>(4);
		for(int i = 0; i < 4; ++i)
		{
			PlayerVal[i] = PlayersHands[i] + PlayersEquips[i] + PlayersHP[i];
		}

		for(int i = 0; i < 4; ++i)
		{
			ret[i] = PlayerVal[0] * SusMatrix[0][i]
				+ PlayerVal[1] * SusMatrix[1][i]
				+ PlayerVal[2] * SusMatrix[2][i]
				+ PlayerVal[3] * SusMatrix[3][i];
		}

		return ret;
	}
}
