using UnityEngine;

public class Card : MonoBehaviour
{
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	[SerializeField] Player m_player;
	[SerializeField] GameManager m_gm;
	[SerializeField] UIManager m_ui;
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

	public void InjectManagers(GameManager gm, UIManager ui)
	{
		m_gm = gm;
		m_ui = ui;
	}

	public void OnPlayed()
	{
		if(!m_gm || !m_ui)
		{
			return;
		}

		m_cardInfoSO.CardAction(m_player, m_gm, m_ui);
	}
}
