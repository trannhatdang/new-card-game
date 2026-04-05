using UnityEngine;
using Cysharp.Threading.Tasks;

public class MainPlayer : Player
{
	public override void BeginTurn()
	{
		//enable UI

	
	}

	public override void EndTurn()
	{
		//disable UI
		
	}

	public override async UniTask<Player> StartPlayerPicker()
	{
		return await m_gameManager.StartPlayerPicker();
	}

	public override async UniTask<Card> StartCardPicker()
	{
		return await m_gameManager.StartCardPicker();
	}
}
