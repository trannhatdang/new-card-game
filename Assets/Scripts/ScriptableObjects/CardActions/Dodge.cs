
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/CardAction/Dodge")]
public abstract class Dodge : CardAction
{
	public override bool OnDodge()
	{
		return true;
	}
}
