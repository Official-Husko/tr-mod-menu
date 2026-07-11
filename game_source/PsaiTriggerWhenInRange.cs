using UnityEngine;

public class PsaiTriggerWhenInRange : PsaiColliderBasedTrigger
{
	public float triggerRadius = 40f;

	public float minimumIntensity = 0.5f;

	public float maximumIntensity = 1f;

	public bool scaleIntensityByDistance = true;

	private float IEBNNBBNFMG;

	public void GLBBLOHJIMM()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	public void HKKJJCGDPMC()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	public void OGHADLBNDLI()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	private void OPCDJCAEODE()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	private void JDCEENNBJPF()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	public void CLKJNPEIBIF()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	public void KKKKPBCFPIP()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	private void MPBDIFPMNAO()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	public void PMNEBBLCHFK()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	public void MJJELJGLBAJ()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	private void CAIOKCFMHEH()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	private void EODLIBKIABF()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	private void BMCJJMHJOGA()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	public void BKMNAKCDJIA()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	private void IJAFKIKGIKJ()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	public void ECLOBOODCLJ()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	public void COHKKCLIJHB()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	private void NAMPAFKKHPF()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	private void MNPAMOKLBEA()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	public void DPEJKBLBCFJ()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	private void GDDMMEBPHCD()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	public void IPMFOLLDKIN()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	private void AMIBKOEAAKK()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	private void LPHJFJLDMLK()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	private void DNOHJELGLBP()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	public void FBGILCBNAGE()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	public void LDCCNCLAEKN()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	public PsaiTriggerWhenInRange()
	{
		PGNDCDCGANJ = true;
	}

	public override float CalculateTriggerIntensity()
	{
		if (scaleIntensityByDistance)
		{
			float num = 1f - IEBNNBBNFMG / triggerRadius;
			return Mathf.Lerp(minimumIntensity, maximumIntensity, num);
		}
		return maximumIntensity;
	}

	public void CLAOPGMNFNI()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	public void LKDCPLNLFGD()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	public void KANPPOPKPMH()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	public void DMGOIFMJIND()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	private void DIPLELFDFML()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	public void KCLDAJGMKHA()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	public void POGODEHDPPA()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	private void GIHAAGDDCAJ()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	public void DIHMOFDIKHO()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	private void GFLOGJIDHFJ()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	private void EOOMOPOAHBA()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	public void OANPOFNAKCG()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	public void PJAONEBJNAI()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	private void ELAAIPPJOGI()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	public void NDDBEPLJJLP()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	private void LEALBCHLEJH()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	public override bool EvaluateTriggerCondition()
	{
		JAGFJKKHIMB();
		return IEBNNBBNFMG < triggerRadius;
	}

	public void OFLEEPIFFEG()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	private void FHOHEDNHJKC()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	public void AAPDPIPCFBH()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	private void PFJJBDIJJDH()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	private void PCCMJENNOHL()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	private void IGDDMNCJEFK()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	private void ODOBLGCBOEO()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	private void EJBDJPLPHHB()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	private void ONJIBDCGEIC()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	public void DGILHOKEKEN()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	private void BCFAJJGGLOC()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	private void FBIOLEPBFGI()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	private void JAGFJKKHIMB()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	private void FKICCBNCOEK()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	public void AHMIDEHBBMA()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	public void OnDrawGizmos()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	public void DOLOFOMKPID()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	private void DJNKNBBHCEM()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	private void LCLDEHIOHGH()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	public void PKCABPDJEID()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	private void DGLNNGBHJIN()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	public void BIKMKHDPHPJ()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	public void HJGEFFMFGBJ()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	public void GEBMCBDHNPL()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(((Component)this).transform.position, triggerRadius);
	}

	private void LFKAJAIFJFA()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	private void HNILOKLONEB()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}

	private void DIOLNBCFFCI()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val2;
		if ((Object)(object)localCollider != (Object)null && (Object)(object)playerCollider != (Object)null)
		{
			Vector3 val = localCollider.ClosestPointOnBounds(((Component)playerCollider).gameObject.transform.position);
			val2 = val - playerCollider.ClosestPointOnBounds(val);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
		else
		{
			val2 = ((Component)this).gameObject.transform.position - playerCollider.ClosestPointOnBounds(((Component)this).gameObject.transform.position);
			IEBNNBBNFMG = ((Vector3)(ref val2)).magnitude;
		}
	}
}
