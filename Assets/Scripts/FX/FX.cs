using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Cysharp.Threading.Tasks;

public abstract class FX : MonoBehaviour
{
	[SerializeField] protected Image m_img;

	protected virtual void Start()
	{
		m_img = GetComponent<Image>();
		gameObject.SetActive(false);
	}
	public abstract void Appear(Vector2 pos, float delay = 0.0f);
}
