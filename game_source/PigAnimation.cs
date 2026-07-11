using UnityEngine;

public class PigAnimation : AnimalAnimation
{
	private float GIFAMPKOLDE;

	private float HPCKCKCODFH;

	protected override void Awake()
	{
		base.Awake();
		GIFAMPKOLDE = Time.time + Random.Range(5f, 15f);
		HPCKCKCODFH = Time.time;
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (walking || base.CNKHDCIKHCO || GetBool("Moving"))
		{
			return;
		}
		if (!GetBool("Loop"))
		{
			if (Time.time >= GIFAMPKOLDE)
			{
				animator.SetTrigger("Eat");
				animator.SetBool("Loop", true);
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
