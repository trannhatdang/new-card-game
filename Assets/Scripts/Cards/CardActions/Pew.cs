using UnityEngine;

[CreateAssetMenu(fileName = "Pew", menuName = "ScriptableObjects/CardAction/Pew")]
public class Pew : CardAction
{
	public override async void Action(Player player, GameManager gm, UIManager ui, Player targetPlayer = null)
	{
		// if(!targetPlayer)
		// {
		// 	targetPlayer = await gm.StartPlayerPicker();
		// }

		Debug.Log("pewing");
	}

	public override async void Action(Player player, Field field, Player targetPlayer = null)
	{

	}
}
