using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UIHand : MonoBehaviour
{
	[SerializeField] int m_defaultWidth;
	[SerializeField] int m_highlightWidth;
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

			m_tfsList[i].anchoredPosition = new Vector2(width * i, m_tfsList[i].anchoredPosition.y);
		}

	}

	public void Highlight(int index)
	{
		m_tfsList[index].sizeDelta = new Vector2(m_highlightWidth, m_tfsList[index].sizeDelta.y);
		m_tfsList[index].anchoredPosition = new Vector2(m_tfsList[index].anchoredPosition.x, m_tfsList[index].anchoredPosition.y);
		position();
	}

	public void Reset()
	{
		for(int i = 0; i < m_tfsList.Count; ++i)
		{
			m_tfsList[i].sizeDelta = new Vector2(m_defaultWidth, m_tfsList[i].sizeDelta.y);
		}
		position();
	}

	public void UpdateChildrenTFS()
	{
		m_tfsList = new List<RectTransform>();
		var all_tfs = GetComponentsInChildren<RectTransform>().ToList();

		for(int i = 0; i < all_tfs.Count; ++i)
		{
			if(all_tfs[i].parent != transform) continue;

			m_tfsList.Add(all_tfs[i]);
			all_tfs[i].sizeDelta = new Vector2(m_defaultWidth, all_tfs[i].sizeDelta[1]);
		}
	}
}
