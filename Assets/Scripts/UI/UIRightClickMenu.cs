using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class UIRightClickMenu : MonoBehaviour
{
	[SerializeField] Button m_playButton;
	[SerializeField] InputAction m_mouse;

	void Start()
	{
		m_mouse = InputSystem.actions.FindAction("Point");
		m_mouse.ReadValue<Vector2>();
	}

	public void Open(UICard card)
	{
		Vector3 mousePos = (Vector3)(m_mouse.ReadValue<Vector2>());
		transform.position = mousePos;

		gameObject.SetActive(true);
		m_playButton.gameObject.SetActive(true);

		m_playButton.onClick.AddListener(() => {
			card.OnPlay();
			Close();
		});
	}

	public void Close()
	{
		gameObject.SetActive(false);
	}
}
