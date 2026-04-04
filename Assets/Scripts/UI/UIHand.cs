using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using DG.Tweening;

public class UIHand : MonoBehaviour
{
	[SerializeField] UIManager m_UIManager;
	[SerializeField] int m_defaultWidth;
	[SerializeField] int m_defaultHeight;
	[SerializeField] int m_highlightWidth;
	[SerializeField] int m_highlightHeight;
	[SerializeField] int m_highlightY;
	[SerializeField] List<RectTransform> m_tfsList;

	void Start()
	{
		UpdateChildrenTFS();
		position();
	}

	// Update is called once per frame
	void Update()
	{
		for(int i = 0; i < m_tfsList.Count; ++i)
		{
			// Debug.Log(m_tfsList[i].sizeDelta);
		}
	}

	void position()
	{
		for(int i = 0; i < m_tfsList.Count; ++i)
		{
			var width = m_tfsList[i].sizeDelta[0];
			var height = m_tfsList[i].sizeDelta[1];

			m_tfsList[i].DOAnchorPos(new Vector2(width * i, m_tfsList[i].anchoredPosition.y), 0.5f, false);
		}
	}

	public void ChangeOrder(int before, int after)
	{
		Vector2 beforeDelta = m_tfsList[before].sizeDelta;
		Vector2 afterDelta = m_tfsList[after].sizeDelta;

		Vector2 beforePos = m_tfsList[before].anchoredPosition;
		Vector2 afterPos = m_tfsList[after].anchoredPosition;

		m_tfsList[before].sizeDelta = afterDelta;
		m_tfsList[before].anchoredPosition = afterPos;

		m_tfsList[after].sizeDelta = beforeDelta;
		m_tfsList[after].anchoredPosition = beforeDelta;
	}

	public void Highlight(int index)
	{
		// if(index < 0 || index >= m_tfsList.Count)
		// {
		// 	return;
		// }
		//
		// if(index > 0)
		// {
		// 	m_tfsList[index - 1].DOSizeDelta(new Vector2(m_highlightWidth, m_highlightHeight), 0.5f, false);
		// }
		//
		// m_tfsList[index].DOSizeDelta(new Vector2(m_highlightWidth, m_highlightHeight), 0.5f, false);
		float lastX = 0;
		for(int i = 0; i < index; ++i)
		{
			lastX += m_defaultWidth * i;
			m_tfsList[i].DOAnchorPos(new Vector2(lastX, 0), 0.5f, false);
		}
		
		lastX += (m_highlightWidth / 2);
		m_tfsList[index].DOAnchorPos(new Vector2(lastX, m_highlightY), 0.5f, false);
		lastX += (m_highlightWidth / 2);

		for(int i = index + 1; i < m_tfsList.Count; ++i)
		{
			lastX += m_defaultWidth * i;
			m_tfsList[i].DOAnchorPos(new Vector2(lastX, 0), 0.5f, false);
		}
		// position();
	}

	public void Highlight(RectTransform tfs)
	{
		for(int i = 0; i < m_tfsList.Count; ++i)
		{
			if(m_tfsList[i] == tfs)
			{
				Highlight(i);
				return;
			}
		}
	}

	public void Reset()
	{
		for(int i = 0; i < m_tfsList.Count; ++i)
		{
			// m_tfsList[i].DOSizeDelta(new Vector2(m_defaultWidth, m_tfsList[i].sizeDelta.y), 0.5f, false);
			m_tfsList[i].DOAnchorPos(new Vector2(m_defaultWidth * i, 0), 0.5f, false);
		}
	}

	public void UpdateChildrenTFS()
	{
		m_tfsList = new List<RectTransform>();
		var all_tfs = GetComponentsInChildren<RectTransform>().ToList();

		for(int i = 0; i < all_tfs.Count; ++i)
		{
			if(all_tfs[i].parent != transform) continue;

			m_tfsList.Add(all_tfs[i]);
		}
	}

	public void RemoveCard(RectTransform tfs)
	{
		if(!m_tfsList.Contains(tfs)) 
		{
			return;
		}

		m_tfsList.Remove(tfs);
	}

	public void OpenRightClickMenu(UICard card)
	{
		m_UIManager.OpenRightClickMenu(card);
	}
}
