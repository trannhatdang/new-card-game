using UnityEngine;

public class Card : MonoBehaviour
{
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	[SerializeField] Hand m_hand;
	[SerializeField] CardInfoSO m_cardInfoSO;

	public CardInfoSO CardInfo
	{
		get { return m_cardInfoSO; }
	}

	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void SetRightClickOptions(UIRightClickMenu menu)
	{
		m_cardInfoSO.SetRightClickOptions(menu);
	}

	public void OnPlay(Player targetPlayer = null)
	{
		m_hand.PlayCard(this, targetPlayer);
	}

	public bool OnDodge(Player shooter = null)
	{
		if (m_cardInfoSO.OnDodge())
		{
			return this;
		}

		return true;
	}

	public void RemoveFromHand()
	{
		m_hand.RemoveCard(this);
	}
}
