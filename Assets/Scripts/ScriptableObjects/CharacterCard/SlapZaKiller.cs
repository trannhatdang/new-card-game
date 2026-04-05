using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/CharacterCard/SlapZaKiller")]
public class SlapZaKiller : CharacterCard
{
	public override void PewDecorator(Player player, GameManager gm, Player targetPlayer)
	{
		gm.Pew(player, targetPlayer, 2);
	}
}
