using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/CardInfos/PewSO")]
public class PewSO : CardInfoSO
{
	public override async void CardAction(Player player, GameManager gm, Player targetPlayer = null, Card targetCard = null)
	{
		if (!targetPlayer)
		{
			targetPlayer = await player.StartPlayerPicker();
		}

		player.Character.PewDecorator(player, gm, targetPlayer);
	}

	public override async void CardAction(Player player, Field field, Player targetPlayer = null, Card targetCard = null)
	{

	}

	public override void SetRightClickOptions(UIRightClickMenu menu)
	{
		menu.SetActive(true);
		menu.SetPlay(true);
	}
}
