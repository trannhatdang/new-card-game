using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class UIRightClickMenu : MonoBehaviour, IPointerExitHandler
{
	[SerializeField] Button m_playButton;
	[SerializeField] InputAction m_mouse;

	void Awake()
	{
		m_mouse = InputSystem.actions.FindAction("Point");
		Close();
	}

	public void SetPlay(bool val)
	{
		m_playButton.gameObject.SetActive(val);
	}

	public void SetActive(bool val)
	{
		gameObject.SetActive(val);
	}

	public void Open(UICard card)
	{
		Vector3 mousePos = (Vector3)(m_mouse.ReadValue<Vector2>());

		transform.position = mousePos;

		card.SetRightClickOptions(this);

		m_playButton.onClick.AddListener(() =>
		{
			card.OnPlay();
			Close();
		});
	}

	public void Close()
	{
		gameObject.SetActive(false);
	}

	public void OnPointerExit(PointerEventData pointer)
	{
		Close();
	}
}
