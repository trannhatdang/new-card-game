using UnityEngine.EventSystems;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using DG.Tweening;

public class UICard : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
	[SerializeField] Card m_card;
	[SerializeField] UIHand m_UIHand;

	public void OnPlay()
	{
		m_card.OnPlay();
	}

	public void OnHover()
	{
		m_UIHand.Highlight(transform.parent.transform as RectTransform);
	}

	public void OnPointerEnter(PointerEventData pointer)
	{
		OnHover();
	}

	public void OnPointerExit(PointerEventData pointer)
	{
		m_UIHand.Reset();
	}

	public void OnPointerClick(PointerEventData pointer)
	{
		if(pointer.button == PointerEventData.InputButton.Right)
		{
			m_UIHand.OpenRightClickMenu(this);
		}
	}
}
