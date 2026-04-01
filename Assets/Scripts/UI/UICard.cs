using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using DG.Tweening;

public class UICard : MonoBehaviour
{
	[SerializeField] Card m_card;
	[SerializeField] UIHand m_UIHand;

	public void OnClick()
	{
		m_card.OnPlayed();
	}

	public void OnHover()
	{

	}
}
