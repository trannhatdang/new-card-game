using UnityEngine;
using DG.Tweening;
using Cysharp.Threading.Tasks;

public class PewFX : FX
{
	[SerializeField] Animator m_anim;

	protected override void Start()
	{
		m_anim = GetComponent<Animator>();
		base.Start();
	}

	public override void Appear(Vector2 pos, float delay = 0.0f)
	{

	}

	public async UniTask Appear(Vector2 startPos, Vector2 endPos)
	{
		gameObject.SetActive(true);
		Vector2 dir = endPos - startPos;
		float angle = Vector2.Angle(dir, Vector2.right);
		(transform as RectTransform).Rotate(0, 0, angle);

		m_img.DOFade(1.0f, 0);

		(transform as RectTransform).position = (Vector3)startPos;
		await (transform as RectTransform).DOMove(endPos, 0.5f, false).AsyncWaitForCompletion();
		await m_img.DOFade(0, 0.25f).AsyncWaitForCompletion();

		(transform as RectTransform).Rotate(0, 0, -angle);
		gameObject.SetActive(false);

	}
}
