using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/CardInfos/DodgeSO")]
public class DodgeSO : CardInfoSO
{
	public override async void CardAction(Player player, GameManager gm, Player targetPlayer = null, Card targetCard = null)
	{

	}

	public override async void CardAction(Player player, Field field, Player targetPlayer = null, Card targetCard = null)
	{

	}

	public override bool OnDodge()
	{
		return true;
	}
}
