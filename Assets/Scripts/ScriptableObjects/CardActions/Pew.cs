using UnityEngine;

[CreateAssetMenu(fileName = "Pew", menuName = "ScriptableObjects/CardAction/Pew")]
public class Pew : CardAction
{
	public override async void Action(Player player, GameManager gm, Player targetPlayer = null, Card targetCard = null)
	{
		if (!targetPlayer)
		{
			targetPlayer = await player.StartPlayerPicker();
		}

		player.Character.PewDecorator(player, gm, targetPlayer);
	}

	public override async void Action(Player player, Field field, Player targetPlayer = null, Card targetCard = null)
	{

	}

	public override void SetRightClickOptions(UIRightClickMenu menu)
	{
		menu.SetActive(true);
		menu.SetPlay(true);
	}
}
