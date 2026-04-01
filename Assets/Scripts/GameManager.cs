using UnityEngine;

public class GameManager : MonoBehaviour
{
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	[SerializeField] UIManager m_ui;
	[SerializeField] DeckInfoSO m_deckInfoSO;

	bool m_pickingPlayer = false;
	bool m_pickingCard = false;
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void StartPlayerPicker()
	{
		m_pickingPlayer = true;
	}

	public void StartCardPicker()
	{
		m_pickingCard = true;
	}

	public void PickPlayer(Player player)
	{

		m_pickingPlayer = false;
	}

	public void PickCard(Card card)
	{

		m_pickingCard = false;
	}
}
