using UnityEngine;

public class Card : MonoBehaviour
{
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	[SerializeField] Player m_player;
	[SerializeField] GameManager m_gm;
	[SerializeField] CardInfoSO m_cardInfoSO;

	public CardInfoSO CardInfo {
		get { return m_cardInfoSO; }
	}

	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void SetGameManager(GameManager gm)
	{
		m_gm = gm;
	}

	public void OnPlayed()
	{
		m_cardInfoSO.CardAction(m_player, m_gm);
	}
}
