using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "CharacterCardInfoSO", menuName = "ScriptableObjects/CharacterCardInfoSO")]
public class CharacterCardInfoSO : ScriptableObject
{
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	[SerializeField] string m_name;
	[SerializeField] string m_descript;
	[SerializeField] Sprite m_sprite;
	
	public void CharacterCardAction(Player player, GameManager gm)
	{

	}
}
