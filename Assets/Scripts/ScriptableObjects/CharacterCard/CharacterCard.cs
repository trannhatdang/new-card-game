using System.Collections.Generic;
using UnityEngine;

public class CharacterCard : ScriptableObject
{
	public virtual void CardAction(CardInfoSO card, Player player, GameManager gm, Player targetPlayer = null, Card targetCard = null)
	{

	}

	public virtual void CardAction(CardInfoSO card, Player player, Field field, Player targetPlayer = null, Card targetCard = null)
	{

	}

	public virtual bool ShotReaction(Player player, GameManager gm, Player shooter, int requiredDodges = 1)
	{
		List<Card> cardList = player.CardList;
		List<Card> dodges = new List<Card>();
		bool dodging = false;

		foreach (Card card in cardList)
		{
			if (card.OnDodge())
			{
				dodges.Add(card);
			}

			if (dodges.Count >= requiredDodges)
			{
				break;
			}
		}

		if (dodging)
		{
			return false;
		}
		else
		{
			HitReaction(player, gm, shooter);
			return true;
		}
	}

	public virtual void HitReaction(Player player, GameManager gm, Player shooter)
	{
		player.HP--;
	}

	public virtual void PewDecorator(Player player, GameManager gm, Player targetPlayer)
	{
		gm.Pew(player, targetPlayer);
	}

	public virtual void DrawDecorator(Player player, GameManager gm)
	{

	}

	public virtual void CardChangeReaction(Player player, GameManager gm)
	{

	}
}
