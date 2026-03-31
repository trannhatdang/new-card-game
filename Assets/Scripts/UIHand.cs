using System.Collections.Generic;
using UnityEngine;

public class UIHand : MonoBehaviour
{
	[SerializeField] int m_defaultWidth;
	[SerializeField] List<Transform> m_gbList;
	[SerializeField] List<int> m_widthList;
	void Start()
	{
		m_gbList = GetComponentsInChildren<Transform>().ToList();

		m_widthList = new List<int>(m_gbList.Count);
		foreach(int width in m_widthList)
		{
			width = m_defaultWidth;
		}


	}

	public void UpdateWidth(int index, int val)
	{
		m_widthList[index] = val;
	}
}
