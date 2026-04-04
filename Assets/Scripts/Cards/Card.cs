using UnityEngine;

public class Card : MonoBehaviour
{
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	[SerializeField] Hand m_hand;
	[SerializeField] GameManager m_gameManager;
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

	public void InjectManagers(GameManager gm)
	{
		m_gameManager = gm;
	}

	public void OnPlay(Player targetPlayer = null)
	{
		m_hand.PlayCard(this, targetPlayer);
	}
}
