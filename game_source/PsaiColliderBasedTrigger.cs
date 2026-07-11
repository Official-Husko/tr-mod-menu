using UnityEngine;

public abstract class PsaiColliderBasedTrigger : PsaiSynchronizedTrigger
{
	public Collider playerCollider;

	public Collider localCollider;

	private void GCJJBJAOMNF()
	{
		if ((Object)(object)localCollider == (Object)null)
		{
			localCollider = ((Component)this).GetComponent<Collider>();
		}
		if ((Object)(object)localCollider == (Object)null)
		{
			Debug.LogError((object)string.Format("psai: The game object lacks a local Collider component for psai Trigger: {0}", ((Component)this).gameObject, ((object)this).ToString()));
		}
	}

	private void AFPFJFICEBD()
	{
		GameObject val = GameObject.FindGameObjectWithTag("Player");
		if ((Object)(object)val == (Object)null)
		{
			string[] array = new string[3] { "Player", "player", "PLAYER" };
			for (int i = 0; i < array.Length; i++)
			{
				val = GameObject.Find(array[i]);
				if ((Object)(object)val != (Object)null)
				{
					break;
				}
			}
		}
		if ((Object)(object)val != (Object)null)
		{
			playerCollider = val.GetComponent<Collider>();
			if ((Object)(object)playerCollider == (Object)null)
			{
				playerCollider = val.GetComponentInChildren<Collider>();
			}
		}
		if ((Object)(object)playerCollider == (Object)null)
		{
			Debug.LogError((object)$"psai: No Player Collider could be found for component {((object)this).ToString()}. Please assign the 'Player' tag to your player object, or assign the collider manually.");
		}
		else if (PsaiCoreManager.HFBLDMHFBDJ.logTriggerScripts)
		{
			Debug.Log((object)$"psai: successfully auto-assigned Player Collider in component {((object)this).ToString()}");
		}
	}

	private void Start()
	{
		if ((Object)(object)playerCollider == (Object)null)
		{
			AFPFJFICEBD();
		}
		if ((Object)(object)localCollider == (Object)null)
		{
			GCJJBJAOMNF();
		}
	}
}
