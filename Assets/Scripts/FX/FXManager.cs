using UnityEngine;

public class FXManager : MonoBehaviour
{
	[SerializeField] DodgeFX m_dodgeFX;
	[SerializeField] PewFX m_pewFX;
	[SerializeField] ShotFX m_shotFX;

	public async void Pew(Player shooter, Player target)
	{
		await m_pewFX.Appear(shooter.transform.position, target.transform.position);
		m_shotFX.Appear(target.transform.position);
	}

	public async void Dodge(Player shooter, Player target)
	{
		await m_pewFX.Appear(shooter.transform.position, target.transform.position);
		m_dodgeFX.Appear(target.transform.position);
	}
}
