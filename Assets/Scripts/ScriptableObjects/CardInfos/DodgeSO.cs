using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/CardInfos/DodgeSO")]
public class DodgeSO : CardInfoSO
{
	public override bool OnDodge()
	{
		return true;
	}
}
