using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Cysharp.Threading.Tasks;

public class GameManager : MonoBehaviour
{
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	[SerializeField] GameState m_state;
	[SerializeField] UIManager m_UI;
	[SerializeField] DeckInfoSO m_deckInfoSO;

	[SerializeField] List<Player> m_playerList;
	[SerializeField] List<PlayerRole> m_playerRoles;
	[SerializeField] int m_currPlayer;

	Player m_playerPicked;
	Card m_cardPicked;

	void Start()
	{
		//initialize game
		m_currPlayer = 0;
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void NextTurn()
	{
		m_playerList[m_currPlayer++].EndTurn();
		m_playerList[m_currPlayer].BeginTurn();
	}

	public async UniTask<Player> StartPlayerPicker()
	{
		m_state = GameState.Picking;
		await UniTask.WaitUntilValueChanged(this, x => x.m_playerPicked);

		m_state = GameState.Playing;
		return m_playerPicked;
	}

	public async UniTask<Card> StartCardPicker()
	{
		m_state = GameState.Picking;
		await UniTask.WaitUntilValueChanged(this, x => x.m_cardPicked);

		m_state = GameState.Playing;
		return m_cardPicked;
	}

	public void PickPlayer(Player player)
	{
		m_playerPicked = player;
	}

	public void PickCard(Card card)
	{
		m_cardPicked = card;
	}

	public Field GetField()
	{
		List<int> playerCardsNum = new List<int>();

		for(int i = 0; i < m_playerList.Count; ++i)
		{
			playerCardsNum.Add(m_playerList[i].GetNumCardsLeft());
		}

		return new Field(m_playerList.Count, m_playerRoles, playerCardsNum);
	}

	public Player GetPlayer(int index)
	{
		return m_playerList[index];
	}

	// void OnGUI()
	// {
	// 	if (GUI.Button(new Rect(500, 500, 50, 100), "Start Player Picker"))
	// 	{
	// 		print("You clicked the button!");
	// 		_ = StartPlayerPicker(); //to ignore warning
	// 	}
	// }
}
