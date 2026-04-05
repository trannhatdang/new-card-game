using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Cysharp.Threading.Tasks;

public class GameManager : MonoBehaviour
{
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	[SerializeField] GameState m_state;
	[SerializeField] UIManager m_UIManager;
	[SerializeField] DeckInfoSO m_deckInfoSO;

	[SerializeField] List<Player> m_playerList;
	[SerializeField] List<PlayerRole> m_playerRoles;
	[SerializeField] int m_currPlayer;

	[SerializeField] List<List<int>> m_susMatrix;

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
		m_UIManager.StartPlayerPicker();
		await UniTask.WaitUntilValueChanged(this, x => x.m_playerPicked);

		m_UIManager.EndPlayerPicker();
		m_state = GameState.Playing;
		Player ret = m_playerPicked;
		m_playerPicked = null;
		return ret;
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

	public List<int> GetPlayersCards()
	{
		List<int> playerCardsNum = new List<int>();

		for (int i = 0; i < m_playerList.Count; ++i)
		{
			playerCardsNum.Add(m_playerList[i].GetNumCardsLeft());
		}

		return playerCardsNum;
	}

	public List<int> GetPlayersEquippedCards()
	{
		List<int> playerEquippedCardsNum = new List<int>();
		for (int i = 0; i < m_playerList.Count; ++i)
		{
			playerEquippedCardsNum.Add(m_playerList[i].GetNumEquippedCards());
		}

		return playerEquippedCardsNum;
	}

	public List<int> GetPlayersHP()
	{
		List<int> playerHP = new List<int>();
		for (int i = 0; i < m_playerList.Count; ++i)
		{
			playerHP.Add(m_playerList[i].HP);
		}

		return playerHP;
	}

	public List<CharacterCard> GetPlayersCharacters()
	{
		List<CharacterCard> playerCharacters = new List<CharacterCard>();
		for (int i = 0; i < m_playerList.Count; ++i)
		{
			playerCharacters.Add(m_playerList[i].Character);
		}

		return playerCharacters;
	}

	public Field GetField()
	{
		List<int> playerCardsNum = GetPlayersCards();
		List<int> playerEquippedCardsNum = GetPlayersEquippedCards();
		List<int> playerHP = GetPlayersHP();
		List<CharacterCard> playerCharacters = GetPlayersCharacters();

		return new Field(m_playerRoles, playerCardsNum, playerEquippedCardsNum,
				playerHP, playerCharacters, m_susMatrix);
	}

	public Player GetPlayer(int index)
	{
		return m_playerList[index];
	}

	public async void Pew(Player shooter, Player target, int requiredDodges = 1)
	{
		bool success = await target.Shot(shooter, requiredDodges);

		if (success)
		{
			m_UIManager.Pew(shooter, target);
		}
		else
		{
			m_UIManager.Dodge(shooter, target);
		}
	}

	public async void Draw(Player drawer, DeckInfoSO source)
	{

	}

	public async void Draw(Player drawer, Player source)
	{

	}

	public async void Equip(Player equipper)
	{

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
