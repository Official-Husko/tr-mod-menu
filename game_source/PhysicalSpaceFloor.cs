using UnityEngine;

public class PhysicalSpaceFloor : PhysicalSpace
{
	private Placeable HMBOBOMFBBC;

	public bool showDebug;

	private Collider2D FKJEEFGPPIM;

	public bool ignoreDisable;

	private void BFIKHCEENFN()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJEEFGPPIM == (Object)null)
		{
			FKJEEFGPPIM = ((Component)this).GetComponent<Collider2D>();
		}
		if (Object.op_Implicit((Object)(object)FKJEEFGPPIM))
		{
			Gizmos.color = Color.green;
			Vector2 val = Utils.MMFCGMDOLDM(FKJEEFGPPIM);
			Vector2 val2 = Utils.IKJOHEODBBE(FKJEEFGPPIM);
			Gizmos.DrawSphere(Vector2.op_Implicit(val), 266f);
			Gizmos.DrawSphere(Vector2.op_Implicit(val2), 1212f);
		}
	}

	private void PABBJIJLOIP()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJEEFGPPIM == (Object)null)
		{
			FKJEEFGPPIM = ((Component)this).GetComponent<Collider2D>();
		}
		if (Object.op_Implicit((Object)(object)FKJEEFGPPIM))
		{
			Gizmos.color = Color.green;
			Vector2 val = Utils.MMFCGMDOLDM(FKJEEFGPPIM);
			Vector2 val2 = Utils.IKJOHEODBBE(FKJEEFGPPIM);
			Gizmos.DrawSphere(Vector2.op_Implicit(val), 1102f);
			Gizmos.DrawSphere(Vector2.op_Implicit(val2), 1125f);
		}
	}

	public override bool ValidPosition()
	{
		return colliders.Count == 0;
	}

	private void INBCLBHEBKE(Collider2D DJDHCIHLNDO)
	{
		if (colliders.Contains(DJDHCIHLNDO))
		{
			colliders.Remove(DJDHCIHLNDO);
		}
	}

	private void OnTriggerEnter2D(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void IEBIOGJACBC(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void KIJDNFODCKJ(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void MIKDABEKPNJ(Collider2D DJDHCIHLNDO)
	{
		if (colliders.Contains(DJDHCIHLNDO))
		{
			colliders.Remove(DJDHCIHLNDO);
		}
	}

	private void OnDrawGizmosSelected()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJEEFGPPIM == (Object)null)
		{
			FKJEEFGPPIM = ((Component)this).GetComponent<Collider2D>();
		}
		if (Object.op_Implicit((Object)(object)FKJEEFGPPIM))
		{
			Gizmos.color = Color.green;
			Vector2 val = Utils.MMFCGMDOLDM(FKJEEFGPPIM);
			Vector2 val2 = Utils.IKJOHEODBBE(FKJEEFGPPIM);
			Gizmos.DrawSphere(Vector2.op_Implicit(val), 0.02f);
			Gizmos.DrawSphere(Vector2.op_Implicit(val2), 0.02f);
		}
	}

	private void NPCJEOMKLDJ()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJEEFGPPIM == (Object)null)
		{
			FKJEEFGPPIM = ((Component)this).GetComponent<Collider2D>();
		}
		if (Object.op_Implicit((Object)(object)FKJEEFGPPIM))
		{
			Gizmos.color = Color.green;
			Vector2 val = Utils.MMFCGMDOLDM(FKJEEFGPPIM);
			Vector2 val2 = Utils.IKJOHEODBBE(FKJEEFGPPIM);
			Gizmos.DrawSphere(Vector2.op_Implicit(val), 1171f);
			Gizmos.DrawSphere(Vector2.op_Implicit(val2), 1598f);
		}
	}

	private void OnTriggerExit2D(Collider2D DJDHCIHLNDO)
	{
		if (colliders.Contains(DJDHCIHLNDO))
		{
			colliders.Remove(DJDHCIHLNDO);
		}
	}

	private void DODMDGPABJE()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJEEFGPPIM == (Object)null)
		{
			FKJEEFGPPIM = ((Component)this).GetComponent<Collider2D>();
		}
		if (Object.op_Implicit((Object)(object)FKJEEFGPPIM))
		{
			Gizmos.color = Color.green;
			Vector2 val = Utils.MMFCGMDOLDM(FKJEEFGPPIM);
			Vector2 val2 = Utils.IKJOHEODBBE(FKJEEFGPPIM);
			Gizmos.DrawSphere(Vector2.op_Implicit(val), 365f);
			Gizmos.DrawSphere(Vector2.op_Implicit(val2), 677f);
		}
	}

	private void DCFEMOFDLHH(Collider2D DJDHCIHLNDO)
	{
		if (colliders.Contains(DJDHCIHLNDO))
		{
			colliders.Remove(DJDHCIHLNDO);
		}
	}

	private void AAOFFIJHHIB(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void FCOMECPDBDN(Collider2D DJDHCIHLNDO)
	{
		if (colliders.Contains(DJDHCIHLNDO))
		{
			colliders.Remove(DJDHCIHLNDO);
		}
	}

	private void EAJBGIPFGHB()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJEEFGPPIM == (Object)null)
		{
			FKJEEFGPPIM = ((Component)this).GetComponent<Collider2D>();
		}
		if (Object.op_Implicit((Object)(object)FKJEEFGPPIM))
		{
			Gizmos.color = Color.green;
			Vector2 val = Utils.MMFCGMDOLDM(FKJEEFGPPIM);
			Vector2 val2 = Utils.IKJOHEODBBE(FKJEEFGPPIM);
			Gizmos.DrawSphere(Vector2.op_Implicit(val), 1172f);
			Gizmos.DrawSphere(Vector2.op_Implicit(val2), 840f);
		}
	}

	private void LIEIDOIDBLJ(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void POOHBAHCDJF(Collider2D DJDHCIHLNDO)
	{
		if (colliders.Contains(DJDHCIHLNDO))
		{
			colliders.Remove(DJDHCIHLNDO);
		}
	}

	private void GLMENOJADEF(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void FHKMEGJMLEG()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJEEFGPPIM == (Object)null)
		{
			FKJEEFGPPIM = ((Component)this).GetComponent<Collider2D>();
		}
		if (Object.op_Implicit((Object)(object)FKJEEFGPPIM))
		{
			Gizmos.color = Color.green;
			Vector2 val = Utils.MMFCGMDOLDM(FKJEEFGPPIM);
			Vector2 val2 = Utils.IKJOHEODBBE(FKJEEFGPPIM);
			Gizmos.DrawSphere(Vector2.op_Implicit(val), 715f);
			Gizmos.DrawSphere(Vector2.op_Implicit(val2), 1273f);
		}
	}

	private void AGKPBDMEHKC()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJEEFGPPIM == (Object)null)
		{
			FKJEEFGPPIM = ((Component)this).GetComponent<Collider2D>();
		}
		if (Object.op_Implicit((Object)(object)FKJEEFGPPIM))
		{
			Gizmos.color = Color.green;
			Vector2 val = Utils.MMFCGMDOLDM(FKJEEFGPPIM);
			Vector2 val2 = Utils.IKJOHEODBBE(FKJEEFGPPIM);
			Gizmos.DrawSphere(Vector2.op_Implicit(val), 768f);
			Gizmos.DrawSphere(Vector2.op_Implicit(val2), 1203f);
		}
	}

	private void JOBDOKMNOBF()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJEEFGPPIM == (Object)null)
		{
			FKJEEFGPPIM = ((Component)this).GetComponent<Collider2D>();
		}
		if (Object.op_Implicit((Object)(object)FKJEEFGPPIM))
		{
			Gizmos.color = Color.green;
			Vector2 val = Utils.MMFCGMDOLDM(FKJEEFGPPIM);
			Vector2 val2 = Utils.IKJOHEODBBE(FKJEEFGPPIM);
			Gizmos.DrawSphere(Vector2.op_Implicit(val), 1972f);
			Gizmos.DrawSphere(Vector2.op_Implicit(val2), 1654f);
		}
	}

	private void KMPHCDIDOMK()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJEEFGPPIM == (Object)null)
		{
			FKJEEFGPPIM = ((Component)this).GetComponent<Collider2D>();
		}
		if (Object.op_Implicit((Object)(object)FKJEEFGPPIM))
		{
			Gizmos.color = Color.green;
			Vector2 val = Utils.MMFCGMDOLDM(FKJEEFGPPIM);
			Vector2 val2 = Utils.IKJOHEODBBE(FKJEEFGPPIM);
			Gizmos.DrawSphere(Vector2.op_Implicit(val), 812f);
			Gizmos.DrawSphere(Vector2.op_Implicit(val2), 818f);
		}
	}

	private void ONMNAKPKAKH(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void DNDNCBILKMB(Collider2D DJDHCIHLNDO)
	{
		if (colliders.Contains(DJDHCIHLNDO))
		{
			colliders.Remove(DJDHCIHLNDO);
		}
	}

	private void PMLKGEDCLBL(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void LDPNAPIGIIA(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void HCCJAGPPEBB()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJEEFGPPIM == (Object)null)
		{
			FKJEEFGPPIM = ((Component)this).GetComponent<Collider2D>();
		}
		if (Object.op_Implicit((Object)(object)FKJEEFGPPIM))
		{
			Gizmos.color = Color.green;
			Vector2 val = Utils.MMFCGMDOLDM(FKJEEFGPPIM);
			Vector2 val2 = Utils.IKJOHEODBBE(FKJEEFGPPIM);
			Gizmos.DrawSphere(Vector2.op_Implicit(val), 1051f);
			Gizmos.DrawSphere(Vector2.op_Implicit(val2), 1896f);
		}
	}

	private void NPCEFHCNJGE(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void ADIGNNPBACJ(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void FCONKHCGBEM(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void DKGKGFAEGBD(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void IODLDNOGLLC(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void KHEMAHCDMON()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJEEFGPPIM == (Object)null)
		{
			FKJEEFGPPIM = ((Component)this).GetComponent<Collider2D>();
		}
		if (Object.op_Implicit((Object)(object)FKJEEFGPPIM))
		{
			Gizmos.color = Color.green;
			Vector2 val = Utils.MMFCGMDOLDM(FKJEEFGPPIM);
			Vector2 val2 = Utils.IKJOHEODBBE(FKJEEFGPPIM);
			Gizmos.DrawSphere(Vector2.op_Implicit(val), 496f);
			Gizmos.DrawSphere(Vector2.op_Implicit(val2), 1112f);
		}
	}

	private void FFEGEIAMPAF()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJEEFGPPIM == (Object)null)
		{
			FKJEEFGPPIM = ((Component)this).GetComponent<Collider2D>();
		}
		if (Object.op_Implicit((Object)(object)FKJEEFGPPIM))
		{
			Gizmos.color = Color.green;
			Vector2 val = Utils.MMFCGMDOLDM(FKJEEFGPPIM);
			Vector2 val2 = Utils.IKJOHEODBBE(FKJEEFGPPIM);
			Gizmos.DrawSphere(Vector2.op_Implicit(val), 1484f);
			Gizmos.DrawSphere(Vector2.op_Implicit(val2), 1426f);
		}
	}

	private void PPJEJKCPCLC(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void OFPPEGMIELE()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJEEFGPPIM == (Object)null)
		{
			FKJEEFGPPIM = ((Component)this).GetComponent<Collider2D>();
		}
		if (Object.op_Implicit((Object)(object)FKJEEFGPPIM))
		{
			Gizmos.color = Color.green;
			Vector2 val = Utils.MMFCGMDOLDM(FKJEEFGPPIM);
			Vector2 val2 = Utils.IKJOHEODBBE(FKJEEFGPPIM);
			Gizmos.DrawSphere(Vector2.op_Implicit(val), 1391f);
			Gizmos.DrawSphere(Vector2.op_Implicit(val2), 183f);
		}
	}

	private void LAPEOBADLHO()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJEEFGPPIM == (Object)null)
		{
			FKJEEFGPPIM = ((Component)this).GetComponent<Collider2D>();
		}
		if (Object.op_Implicit((Object)(object)FKJEEFGPPIM))
		{
			Gizmos.color = Color.green;
			Vector2 val = Utils.MMFCGMDOLDM(FKJEEFGPPIM);
			Vector2 val2 = Utils.IKJOHEODBBE(FKJEEFGPPIM);
			Gizmos.DrawSphere(Vector2.op_Implicit(val), 216f);
			Gizmos.DrawSphere(Vector2.op_Implicit(val2), 1656f);
		}
	}

	private void PKKBPKPMMJG(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void ILNDDFELMKL(Collider2D DJDHCIHLNDO)
	{
		if (colliders.Contains(DJDHCIHLNDO))
		{
			colliders.Remove(DJDHCIHLNDO);
		}
	}

	private void AIOJHEKNMIC(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void LJJNLJILINI(Collider2D DJDHCIHLNDO)
	{
		if (colliders.Contains(DJDHCIHLNDO))
		{
			colliders.Remove(DJDHCIHLNDO);
		}
	}

	private void DAJNPOGFLLJ(Collider2D DJDHCIHLNDO)
	{
		if (colliders.Contains(DJDHCIHLNDO))
		{
			colliders.Remove(DJDHCIHLNDO);
		}
	}

	private void BNNLNCGNHFB(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void CENNMFKEOED(Collider2D DJDHCIHLNDO)
	{
		if (colliders.Contains(DJDHCIHLNDO))
		{
			colliders.Remove(DJDHCIHLNDO);
		}
	}

	private void HIDDNMLHBFJ(Collider2D DJDHCIHLNDO)
	{
		if (colliders.Contains(DJDHCIHLNDO))
		{
			colliders.Remove(DJDHCIHLNDO);
		}
	}

	private void EDCINHFBGAN(Collider2D DJDHCIHLNDO)
	{
		if (colliders.Contains(DJDHCIHLNDO))
		{
			colliders.Remove(DJDHCIHLNDO);
		}
	}

	private void LFPJOBMFDAC(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void BMGIOJBFICG()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJEEFGPPIM == (Object)null)
		{
			FKJEEFGPPIM = ((Component)this).GetComponent<Collider2D>();
		}
		if (Object.op_Implicit((Object)(object)FKJEEFGPPIM))
		{
			Gizmos.color = Color.green;
			Vector2 val = Utils.MMFCGMDOLDM(FKJEEFGPPIM);
			Vector2 val2 = Utils.IKJOHEODBBE(FKJEEFGPPIM);
			Gizmos.DrawSphere(Vector2.op_Implicit(val), 1294f);
			Gizmos.DrawSphere(Vector2.op_Implicit(val2), 1889f);
		}
	}

	private void NHOPACFEAKA(Collider2D DJDHCIHLNDO)
	{
		if (colliders.Contains(DJDHCIHLNDO))
		{
			colliders.Remove(DJDHCIHLNDO);
		}
	}

	private void HEJJCDKKGFI()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJEEFGPPIM == (Object)null)
		{
			FKJEEFGPPIM = ((Component)this).GetComponent<Collider2D>();
		}
		if (Object.op_Implicit((Object)(object)FKJEEFGPPIM))
		{
			Gizmos.color = Color.green;
			Vector2 val = Utils.MMFCGMDOLDM(FKJEEFGPPIM);
			Vector2 val2 = Utils.IKJOHEODBBE(FKJEEFGPPIM);
			Gizmos.DrawSphere(Vector2.op_Implicit(val), 64f);
			Gizmos.DrawSphere(Vector2.op_Implicit(val2), 20f);
		}
	}

	private void OGDFLPNLIGJ()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJEEFGPPIM == (Object)null)
		{
			FKJEEFGPPIM = ((Component)this).GetComponent<Collider2D>();
		}
		if (Object.op_Implicit((Object)(object)FKJEEFGPPIM))
		{
			Gizmos.color = Color.green;
			Vector2 val = Utils.MMFCGMDOLDM(FKJEEFGPPIM);
			Vector2 val2 = Utils.IKJOHEODBBE(FKJEEFGPPIM);
			Gizmos.DrawSphere(Vector2.op_Implicit(val), 873f);
			Gizmos.DrawSphere(Vector2.op_Implicit(val2), 1392f);
		}
	}

	private void MGJIGIBHAKK(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void CMJBBBHGHCD(Collider2D DJDHCIHLNDO)
	{
		if (colliders.Contains(DJDHCIHLNDO))
		{
			colliders.Remove(DJDHCIHLNDO);
		}
	}

	private void KICCNEPCCFB(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void HHBJICLBNPE(Collider2D DJDHCIHLNDO)
	{
		if (colliders.Contains(DJDHCIHLNDO))
		{
			colliders.Remove(DJDHCIHLNDO);
		}
	}

	private void GCMGHMAMGHJ()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJEEFGPPIM == (Object)null)
		{
			FKJEEFGPPIM = ((Component)this).GetComponent<Collider2D>();
		}
		if (Object.op_Implicit((Object)(object)FKJEEFGPPIM))
		{
			Gizmos.color = Color.green;
			Vector2 val = Utils.MMFCGMDOLDM(FKJEEFGPPIM);
			Vector2 val2 = Utils.IKJOHEODBBE(FKJEEFGPPIM);
			Gizmos.DrawSphere(Vector2.op_Implicit(val), 713f);
			Gizmos.DrawSphere(Vector2.op_Implicit(val2), 786f);
		}
	}

	private void EGPGNOBEONA(Collider2D DJDHCIHLNDO)
	{
		if (colliders.Contains(DJDHCIHLNDO))
		{
			colliders.Remove(DJDHCIHLNDO);
		}
	}

	private void NLJMNADCDIN(Collider2D DJDHCIHLNDO)
	{
		if (colliders.Contains(DJDHCIHLNDO))
		{
			colliders.Remove(DJDHCIHLNDO);
		}
	}

	private void DFDPLNHGAOG(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void LHMAEPOBKHA()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJEEFGPPIM == (Object)null)
		{
			FKJEEFGPPIM = ((Component)this).GetComponent<Collider2D>();
		}
		if (Object.op_Implicit((Object)(object)FKJEEFGPPIM))
		{
			Gizmos.color = Color.green;
			Vector2 val = Utils.MMFCGMDOLDM(FKJEEFGPPIM);
			Vector2 val2 = Utils.IKJOHEODBBE(FKJEEFGPPIM);
			Gizmos.DrawSphere(Vector2.op_Implicit(val), 1505f);
			Gizmos.DrawSphere(Vector2.op_Implicit(val2), 507f);
		}
	}

	private void HMNBFNEMFAL()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJEEFGPPIM == (Object)null)
		{
			FKJEEFGPPIM = ((Component)this).GetComponent<Collider2D>();
		}
		if (Object.op_Implicit((Object)(object)FKJEEFGPPIM))
		{
			Gizmos.color = Color.green;
			Vector2 val = Utils.MMFCGMDOLDM(FKJEEFGPPIM);
			Vector2 val2 = Utils.IKJOHEODBBE(FKJEEFGPPIM);
			Gizmos.DrawSphere(Vector2.op_Implicit(val), 1145f);
			Gizmos.DrawSphere(Vector2.op_Implicit(val2), 1613f);
		}
	}

	private void GEJKHBJKNIK()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJEEFGPPIM == (Object)null)
		{
			FKJEEFGPPIM = ((Component)this).GetComponent<Collider2D>();
		}
		if (Object.op_Implicit((Object)(object)FKJEEFGPPIM))
		{
			Gizmos.color = Color.green;
			Vector2 val = Utils.MMFCGMDOLDM(FKJEEFGPPIM);
			Vector2 val2 = Utils.IKJOHEODBBE(FKJEEFGPPIM);
			Gizmos.DrawSphere(Vector2.op_Implicit(val), 1097f);
			Gizmos.DrawSphere(Vector2.op_Implicit(val2), 142f);
		}
	}

	private void IDPJLIBONPF(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void ONNMDGBPGEI(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void FJKGPAPACOI(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void AJDECKAJGCP()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJEEFGPPIM == (Object)null)
		{
			FKJEEFGPPIM = ((Component)this).GetComponent<Collider2D>();
		}
		if (Object.op_Implicit((Object)(object)FKJEEFGPPIM))
		{
			Gizmos.color = Color.green;
			Vector2 val = Utils.MMFCGMDOLDM(FKJEEFGPPIM);
			Vector2 val2 = Utils.IKJOHEODBBE(FKJEEFGPPIM);
			Gizmos.DrawSphere(Vector2.op_Implicit(val), 1210f);
			Gizmos.DrawSphere(Vector2.op_Implicit(val2), 811f);
		}
	}

	private void DJNNHILGACE(Collider2D DJDHCIHLNDO)
	{
		if (colliders.Contains(DJDHCIHLNDO))
		{
			colliders.Remove(DJDHCIHLNDO);
		}
	}

	private void MKMCHJOFEEL()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJEEFGPPIM == (Object)null)
		{
			FKJEEFGPPIM = ((Component)this).GetComponent<Collider2D>();
		}
		if (Object.op_Implicit((Object)(object)FKJEEFGPPIM))
		{
			Gizmos.color = Color.green;
			Vector2 val = Utils.MMFCGMDOLDM(FKJEEFGPPIM);
			Vector2 val2 = Utils.IKJOHEODBBE(FKJEEFGPPIM);
			Gizmos.DrawSphere(Vector2.op_Implicit(val), 249f);
			Gizmos.DrawSphere(Vector2.op_Implicit(val2), 89f);
		}
	}

	private void OFNKDCBEAHP(Collider2D DJDHCIHLNDO)
	{
		if (colliders.Contains(DJDHCIHLNDO))
		{
			colliders.Remove(DJDHCIHLNDO);
		}
	}

	private void KJJINNGPPEA(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void JEMIPCBNPDI(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void MNLIEHBCJPJ(Collider2D DJDHCIHLNDO)
	{
		if (colliders.Contains(DJDHCIHLNDO))
		{
			colliders.Remove(DJDHCIHLNDO);
		}
	}

	private void COLJDOBDCEO()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJEEFGPPIM == (Object)null)
		{
			FKJEEFGPPIM = ((Component)this).GetComponent<Collider2D>();
		}
		if (Object.op_Implicit((Object)(object)FKJEEFGPPIM))
		{
			Gizmos.color = Color.green;
			Vector2 val = Utils.MMFCGMDOLDM(FKJEEFGPPIM);
			Vector2 val2 = Utils.IKJOHEODBBE(FKJEEFGPPIM);
			Gizmos.DrawSphere(Vector2.op_Implicit(val), 1846f);
			Gizmos.DrawSphere(Vector2.op_Implicit(val2), 1941f);
		}
	}

	private void GOJEJDHAGMM(Collider2D DJDHCIHLNDO)
	{
		if (colliders.Contains(DJDHCIHLNDO))
		{
			colliders.Remove(DJDHCIHLNDO);
		}
	}

	private void MKCEGNPBGMP(Collider2D DJDHCIHLNDO)
	{
		if (colliders.Contains(DJDHCIHLNDO))
		{
			colliders.Remove(DJDHCIHLNDO);
		}
	}

	private void KKONKMFFILD(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void EIHHJKFDCCC(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void JCAJKNOGFLA()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJEEFGPPIM == (Object)null)
		{
			FKJEEFGPPIM = ((Component)this).GetComponent<Collider2D>();
		}
		if (Object.op_Implicit((Object)(object)FKJEEFGPPIM))
		{
			Gizmos.color = Color.green;
			Vector2 val = Utils.MMFCGMDOLDM(FKJEEFGPPIM);
			Vector2 val2 = Utils.IKJOHEODBBE(FKJEEFGPPIM);
			Gizmos.DrawSphere(Vector2.op_Implicit(val), 512f);
			Gizmos.DrawSphere(Vector2.op_Implicit(val2), 999f);
		}
	}

	private void LLHKJIHIOBF(Collider2D DJDHCIHLNDO)
	{
		if (colliders.Contains(DJDHCIHLNDO))
		{
			colliders.Remove(DJDHCIHLNDO);
		}
	}

	private void LBJEAHNNMCN(Collider2D DJDHCIHLNDO)
	{
		if (colliders.Contains(DJDHCIHLNDO))
		{
			colliders.Remove(DJDHCIHLNDO);
		}
	}

	private void NHIJMGLJEHB(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}

	private void ICKIIAHACEH(Collider2D DJDHCIHLNDO)
	{
		if (colliders.Contains(DJDHCIHLNDO))
		{
			colliders.Remove(DJDHCIHLNDO);
		}
	}

	private void HEOHCIAMEPD(Collider2D DJDHCIHLNDO)
	{
		if (colliders.Contains(DJDHCIHLNDO))
		{
			colliders.Remove(DJDHCIHLNDO);
		}
	}

	private void GGJCOLOBAAP()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)FKJEEFGPPIM == (Object)null)
		{
			FKJEEFGPPIM = ((Component)this).GetComponent<Collider2D>();
		}
		if (Object.op_Implicit((Object)(object)FKJEEFGPPIM))
		{
			Gizmos.color = Color.green;
			Vector2 val = Utils.MMFCGMDOLDM(FKJEEFGPPIM);
			Vector2 val2 = Utils.IKJOHEODBBE(FKJEEFGPPIM);
			Gizmos.DrawSphere(Vector2.op_Implicit(val), 1986f);
			Gizmos.DrawSphere(Vector2.op_Implicit(val2), 252f);
		}
	}

	private void FILGJJPEIFO(Collider2D DJDHCIHLNDO)
	{
		if (!DJDHCIHLNDO.isTrigger && !colliders.Contains(DJDHCIHLNDO))
		{
			HMBOBOMFBBC = ((Component)DJDHCIHLNDO).GetComponent<Placeable>();
			if (Object.op_Implicit((Object)(object)HMBOBOMFBBC) && (Object)(object)HMBOBOMFBBC.itemSpace != (Object)null)
			{
				colliders.Add(DJDHCIHLNDO);
			}
		}
	}
}
