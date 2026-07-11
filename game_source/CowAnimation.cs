using UnityEngine;

public class CowAnimation : AnimalAnimation
{
	private float JPEGNBFAPGJ;

	private float GIFAMPKOLDE;

	private float HPCKCKCODFH;

	protected override void Awake()
	{
		base.Awake();
		JPEGNBFAPGJ = Time.time + Random.Range(20f, 40f);
		GIFAMPKOLDE = Time.time + Random.Range(5f, 15f);
		HPCKCKCODFH = Time.time;
		FCGBJEIIMBC = Direction.Right;
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (walking || base.CNKHDCIKHCO || GetBool(CharacterAnimBase.HGEBKKGJONI))
		{
			return;
		}
		if (!GetBool(CharacterAnimBase.DIGIHNCFHJD))
		{
			if (Time.time >= JPEGNBFAPGJ)
			{
				animator.SetTrigger(CharacterAnimBase.IAENAGLBEHC);
				if (OnlineManager.IsMasterClient() && (Object)(object)onlineAnimal != (Object)null)
				{
					onlineAnimal.SendSetTrigger(CharacterAnimBase.IAENAGLBEHC);
				}
				JPEGNBFAPGJ = Time.time + Random.Range(20f, 40f);
			}
			if (Time.time >= GIFAMPKOLDE)
			{
				animator.SetTrigger(CharacterAnimBase.ABOMGPELDKP);
				animator.SetBool(CharacterAnimBase.DIGIHNCFHJD, true);
				GIFAMPKOLDE = Time.time + Random.Range(15f, 20f);
				HPCKCKCODFH = Time.time + Random.Range(1f, 3f);
				if (OnlineManager.IsMasterClient() && (Object)(object)onlineAnimal != (Object)null)
				{
					onlineAnimal.SendSetTrigger(CharacterAnimBase.ABOMGPELDKP);
					onlineAnimal.SendSetBool(CharacterAnimBase.DIGIHNCFHJD, AODONKKHPBP: true);
				}
			}
		}
		else if (Time.time >= HPCKCKCODFH)
		{
			animator.SetBool(CharacterAnimBase.DIGIHNCFHJD, false);
			if (OnlineManager.IsMasterClient() && (Object)(object)onlineAnimal != (Object)null)
			{
				onlineAnimal.SendSetBool(CharacterAnimBase.DIGIHNCFHJD, AODONKKHPBP: false);
			}
		}
	}
}
