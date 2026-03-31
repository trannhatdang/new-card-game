using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "DeckInfoSO", menuName = "ScriptableObjects/DeckInfoSO")]
public class DeckInfoSO : ScriptableObject
{
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	[SerializeField] List<CardInfoSO> m_cardInfos;
	
	public void Shuffle()
	{

	}
}
