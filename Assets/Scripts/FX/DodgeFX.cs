using System;
using UnityEngine;
using DG.Tweening;
using Cysharp.Threading.Tasks;

public class DodgeFX : FX
{
	public override async void Appear(Vector2 pos, float delay = 0.0f)
	{
		gameObject.SetActive(true);

		m_img.DOFade(1.0f, 0);
		transform.position = (Vector3)pos;
		await UniTask.Delay(TimeSpan.FromSeconds(delay));

		transform.DOMove((Vector3)pos + new Vector3(0, 10, 0), 0.25f)
			.OnComplete(() =>
			{
				gameObject.SetActive(false);
			});
		m_img.DOFade(0f, 0.25f);
	}
}
