using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/CharacterCard/BartSimpson")]
public class BartSimpson : CharacterCard
{
	public override void HitReaction(Player player, GameManager gm, Player shooter)
	{
		// gm.Draw(player);

	}
}
