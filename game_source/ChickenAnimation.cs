using UnityEngine;

public class ChickenAnimation : AnimalAnimation
{
	private float NMBEPAGELPO;

	private float HPCKCKCODFH;

	private float CBDALHHGLCP;

	private float MLGHPPLDGEG;

	protected override void Awake()
	{
		base.Awake();
		NMBEPAGELPO = Time.time;
		HPCKCKCODFH = Time.time;
		CBDALHHGLCP = Time.time + Random.Range(20f, 40f);
		MLGHPPLDGEG = Time.time + Random.Range(60f, 180f);
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (GetBool(CharacterAnimBase.DIGIHNCFHJD))
		{
			LookDirection(Direction.Left);
		}
		if (!OnlineManager.MasterOrOffline() || walking || base.CNKHDCIKHCO || GetBool(CharacterAnimBase.HGEBKKGJONI))
		{
			return;
		}
		if (!animator.GetBool(CharacterAnimBase.MPEOOHKMKAM) && Time.time >= NMBEPAGELPO)
		{
			animator.SetTrigger(CharacterAnimBase.IBNECEPOKFI);
			animator.SetBool(CharacterAnimBase.PGDOKFIHFPL, true);
			NMBEPAGELPO = Time.time + Random.Range(6f, 10f);
			HPCKCKCODFH = Time.time + Random.Range(1f, 3f);
			if (OnlineManager.IsMasterClient() && (Object)(object)onlineAnimal != (Object)null)
			{
				onlineAnimal.SendSetTrigger(CharacterAnimBase.IBNECEPOKFI);
				onlineAnimal.SendSetBool(CharacterAnimBase.PGDOKFIHFPL, AODONKKHPBP: true);
			}
		}
		if (!animator.GetBool(CharacterAnimBase.PGDOKFIHFPL) && Time.time >= MLGHPPLDGEG)
		{
			animator.SetTrigger(CharacterAnimBase.LNNMIIMJDKO);
			animator.SetBool(CharacterAnimBase.MPEOOHKMKAM, true);
			MLGHPPLDGEG = Time.time + Random.Range(60f, 180f);
			HPCKCKCODFH = Time.time + Random.Range(10f, 30f);
			if (OnlineManager.IsMasterClient() && (Object)(object)onlineAnimal != (Object)null)
			{
				onlineAnimal.SendSetTrigger(CharacterAnimBase.LNNMIIMJDKO);
				onlineAnimal.SendSetBool(CharacterAnimBase.MPEOOHKMKAM, AODONKKHPBP: true);
			}
		}
		if (animator.GetBool(CharacterAnimBase.PGDOKFIHFPL))
		{
			if (Time.time >= CBDALHHGLCP)
			{
				animator.SetTrigger(CharacterAnimBase.MNJMKDEEGDE);
				HPCKCKCODFH = Time.time + Random.Range(1f, 3f);
				CBDALHHGLCP = Time.time + Random.Range(20f, 40f);
				if (OnlineManager.IsMasterClient() && (Object)(object)onlineAnimal != (Object)null)
				{
					onlineAnimal.SendSetTrigger(CharacterAnimBase.MNJMKDEEGDE);
				}
			}
			if (Time.time >= HPCKCKCODFH)
			{
				animator.SetBool(CharacterAnimBase.PGDOKFIHFPL, false);
				if (OnlineManager.IsMasterClient() && (Object)(object)onlineAnimal != (Object)null)
				{
					onlineAnimal.SendSetBool(CharacterAnimBase.PGDOKFIHFPL, AODONKKHPBP: false);
				}
			}
		}
		if (animator.GetBool(CharacterAnimBase.MPEOOHKMKAM) && Time.time >= HPCKCKCODFH)
		{
			animator.SetBool(CharacterAnimBase.MPEOOHKMKAM, false);
			if (OnlineManager.IsMasterClient() && (Object)(object)onlineAnimal != (Object)null)
			{
				onlineAnimal.SendSetBool(CharacterAnimBase.MPEOOHKMKAM, AODONKKHPBP: false);
			}
		}
	}

	public override void OnEnable()
	{
		base.OnEnable();
		NMBEPAGELPO = Time.time;
		HPCKCKCODFH = Time.time;
		CBDALHHGLCP = Time.time + Random.Range(20f, 40f);
		MLGHPPLDGEG = Time.time + Random.Range(60f, 180f);
	}
}
