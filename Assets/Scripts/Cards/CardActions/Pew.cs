using UnityEngine;
public class Pew : CardAction
{
	public override async void Action(Player player, GameManager gm, UIManager ui)
	{
		Player chosenPlayer = await gm.StartPlayerPicker();




	}
}
