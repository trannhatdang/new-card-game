using UnityEngine;
public class Pew : CardAction
{
	public override async void Action(Player player, GameManager gm, UIManager ui, Player targetPlayer = null)
	{
		if(!targetPlayer)
		{
			targetPlayer = await gm.StartPlayerPicker();
		}


	}
}
